using GeneticAlgorithmTool.Models;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmTool
{
    public class Species
    {
        public int Id { get; set; }
        public List<FrameAction> Genes { get; set; }
        public int Reward { get; set; }
        public bool Done { get; set; }
        private int currentGen;
        public Species(int id)
        {
            Id = ++id;
            Genes = new List<FrameAction>();
            ResetSpecies();
        }

        public override string ToString()
        {
            return $"Specie: {Id}, Score: {Reward}";
        }

        public void UpdateInformation(StepResponse stepResponse)
        {
            Done = stepResponse.Done;
            var currentFrame = GetCurrentGen();
            currentFrame.Coins = (int)stepResponse.Info.Coins;
            currentFrame.Time = (int)stepResponse.Info.Time;
            currentFrame.Score = (int)stepResponse.Info.Score;
            currentFrame.XPosition = (int)stepResponse.Info.XPosition;
            currentFrame.YPosition = (int)stepResponse.Info.YPosition;
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

        public void RemoveLastCorruptGenes()
        {
            Genes = Genes.Where(gen => gen.YPosition > 0).ToList();
            int lastIndex = Genes.Count() - 1;
            if (Genes[lastIndex].YPosition == 0 || Genes[lastIndex].YPosition >= 250) // death by fall, corrupt genes while Mario is fallind will be removed 
            {
                while (true)
                {
                    var gen = Genes[lastIndex];
                    var prevGen = Genes[lastIndex - 1];
                    if (gen.YPosition == prevGen.YPosition)
                    {
                        break;
                    }
                    Genes.Remove(gen);
                    lastIndex--;
                }
                return;
            }

            Genes.RemoveAt(lastIndex);
        }

        public void ResetSpecies()
        {
            currentGen = 0;
            Reward = 0;
            Done = false;
        }
    }
}
