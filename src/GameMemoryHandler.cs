using BizHawk.Client.Common;
using System;

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

        public void PrelevelTimer() => memory.WriteU8(0x07A0, 0);
    }
}
