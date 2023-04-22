namespace GeneticAlgorithmTool.Models
{
    public class StepInformation
    {
        public uint Level { get; set; }
        public uint World { get; set; }
        public uint Coins { get; set; }
        public uint Score { get; set; }
        public uint Time { get; set; }
        public uint Lives { get; set; }
        public uint XPosition { get; set; }
        public uint YPosition { get; set; }

        public override string ToString()
        {
            return $"Level: {Level}, World: {World}, Coins: {Coins}, Score: {Score}, Time:{Time}, Lives:{Lives}, XPosition: {XPosition}, YPosition: {YPosition}";
        }
    }
}
