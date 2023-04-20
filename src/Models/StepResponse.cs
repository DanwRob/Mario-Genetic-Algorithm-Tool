namespace GeneticAlgorithmTool.Models
{
    public class StepResponse
    {
        public int Reward { get; set; }
        public bool Done { get; set; }
        public StepInformation? Info { get; set; }
    }
}
