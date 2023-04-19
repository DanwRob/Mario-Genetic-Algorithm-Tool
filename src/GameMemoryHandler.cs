using BizHawk.Client.Common;
using System;
using static BizHawk.Client.EmuHawk.WatchEditor;

namespace GeneticAlgorithmTool
{
    public class GameMemoryHandler
    {
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

        public void PrelevelTimer() => memory.WriteU8(0x07A0, 0);
    }
}
