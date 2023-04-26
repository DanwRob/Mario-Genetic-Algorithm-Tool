using GeneticAlgorithmTool.Models;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmTool
{
    public class Species
    {
        private readonly int lastNFrames = 25;
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
            var currentFrame = GetCurrentGen();
           
            currentFrame.Coins = (int)stepResponse.Info.Coins;
            currentFrame.Time = (int)stepResponse.Info.Time;
            currentFrame.Score = (int)stepResponse.Info.Score;
            currentFrame.XPosition = (int)stepResponse.Info.XPosition;
            currentFrame.YPosition = (int)stepResponse.Info.YPosition;

            Done = stepResponse.Done;
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

        public void IsSpecieStuck()
        {
            bool isStuck = true;
            if (currentGen < lastNFrames)
            {
                return;
            }

            var lastGen = Genes[currentGen];
            if (!lastGen.Actions.Contains(Buttons.A))
            {
                return;
            }

            for (int reverseIndex = currentGen - 1; reverseIndex > currentGen - lastNFrames; reverseIndex--)
            {
                var gen = Genes[reverseIndex];
                if (lastGen.XPosition != gen.XPosition)
                {
                    isStuck = false;
                }
                lastGen = gen;
            }

            Done =  isStuck? isStuck : Done;
        }
    }
}
