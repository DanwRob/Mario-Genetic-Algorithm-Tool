using GeneticAlgorithmTool.Models;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmTool
{
    public class Species
    {
        public int Id { get; set; }
        public List<FrameAction> Genes { get; set; }
        public bool State { get; set; }
        public int Score { get; set; }
        public bool Done { get; set; }
        public StepInformation Info { get; set; } = new();
        private int currentGen;
        public Species(int id)
        {
            Id = id;
            Genes = new List<FrameAction>();
            ResetSpecies();
        }

        public override string ToString()
        {
            return $"Species: {Id}, Score: {Score}, Done: {Done}";
        }

        public FrameAction GetCurrentGen()
        {
            return Genes[currentGen];
        }

        public bool IsGenDone()
        {
            if (Genes.Count() == 0)
            {
                return true;
            }

            if (GetCurrentGen().IsFinishAction()) {
                currentGen++;
                return true;
            }

            return false;
        }

        public void ResetSpecies()
        {
            currentGen = 0;
            Score = 0;
            State = false;
            Done = false;
        }
    }
}
