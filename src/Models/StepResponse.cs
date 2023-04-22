namespace GeneticAlgorithmTool.Models
{
    public class StepResponse
    {
        public int Reward { get; set; }
        public bool Done { get; set; }
        public StepInformation Info { get; set; } = new();

        public override string ToString()
        {
            return $"Reward: {Reward}, Done: {Done} \r\n";
        }
    }
}
