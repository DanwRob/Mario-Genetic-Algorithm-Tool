using BizHawk.Client.Common;
using System;
using System.Linq;

namespace GeneticAlgorithmTool
{
    public class GameMemoryHandler
    {
        private static readonly uint[] s_TransitionStates = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x07 };
        private static readonly uint[] s_enemyTypeAddress = { 0x0016, 0x0017, 0x0018, 0x0019, 0x001A};

        public enum GameplayMode
        {
            Demo,
            Standard,
            EndOfWorld
        }
        private readonly IMemoryApi memory;
        public GameMemoryHandler(IMemoryApi memory)
        {
            this.memory = memory;
        }

        public uint Level => memory.ReadU8(0x075C) + 1;

        public uint World => memory.ReadU8(0x075F) + 1;

        public uint Coins => ReadMemRange(0x075E, 2);

        public uint Lives => memory.ReadU8(0x075A);

        public uint Score => ReadMemRange(0x07de, 6);

        public uint Time => ReadMemRange(0x07f8, 3);
        public bool IsInTrasition => s_TransitionStates.Contains(State);
        public bool IsDying => State == 0x0B;
        public bool IsDead => State == 0x06;
        public uint State
        {
            /*Return the current player state.
                0x00 : Leftmost of screen
                0x01 : Climbing vine
                0x02 : Entering reversed-L pipe
                0x03 : Going down a pipe
                0x04 : Auto-walk
                0x05 : Auto-walk
                0x06 : Dead
                0x07 : Entering area
                0x08 : Normal
                0x09 : Cannot move
                0x0A : Cannot move
                0x0B : Dying
                0x0C : Transforming to Fire Mario can't move
            */
            get
            {
                return memory.ReadByte(0x000E);
            }
        }

        private uint ReadMemRange(long addr, int length)
        {
            var bytes = memory.ReadByteRange(addr, length);
            string strValue = String.Join("", bytes);
            return UInt32.Parse(strValue);
        }

        public void SetGameplayMode(GameplayMode mode)
        {
            memory.WriteU8(0x0770, (uint)mode);
        }

        public void PlayerDies()
        {
            memory.WriteByte(0x000E, 0x06);
        }

        public void PrelevelTimer() => memory.WriteByte(0x07A0, 0x00);
        public bool IsWorldEnds() => memory.ReadByte(0x0770) == (uint)GameplayMode.EndOfWorld;
        public bool IsStageEnds()
        {
            foreach (var address in s_enemyTypeAddress)
            {
                if (memory.ReadByte(address) == 0x31)
                {
                    memory.WriteByte(0x001D, 0x03);
                    return true;
                }
            }

            return false;
        }

        public uint XLevelPosition => memory.ReadByte(0x006D);
        public uint XScreenPosition => memory.ReadByte(0x0086);
        public uint YViewPort => memory.ReadByte(0x00B5);

        public uint XPositionOffset => memory.ReadByte(0x03AD);
        public uint PlayerPos => memory.ReadByte(0x071D);
        public uint XPosition()
        {
            return XLevelPosition + XScreenPosition;
        }
    }
}
