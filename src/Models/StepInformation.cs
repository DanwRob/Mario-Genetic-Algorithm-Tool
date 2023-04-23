namespace GeneticAlgorithmTool.Models
{
    public class StepInformation
    {
        public uint Level { get; set; } = 1;
        public uint World { get; set; } = 1;
        public uint Coins { get; set; } = 0;
        public uint Score { get; set; } = 0;
        public uint Time { get; set; } = 400;
        public uint Lives { get; set; } = 2;
        public uint XPosition { get; set; }
        public uint YPosition { get; set; }

        public override string ToString()
        {
            return $"Level: {Level}, World: {World}, Coins: {Coins}, Score: {Score}, Time:{Time}, Lives:{Lives}, XPosition: {XPosition}, YPosition: {YPosition}";
        }
    }
}
