using GeneticAlgorithmTool.Models;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmTool
{
    public class GeneticAlgorithm
    {
        public List<Species> Population { get; private set; }
        public JoypadSpace Joypad { get; set; }
        public int Generation { get; private set; }
        public int TotalGenerations { get; private set; }
        public int PopulationSize { get; private set; }
        public double BestReward { get; private set; }
        public double MutationRate { get; private set; }
        private int currentSpecies = 0;
        private int prevScore = 0;

        public GeneticAlgorithm(int totalGenerations, int populationSize, double mutationRate, JoypadSpace joypad)
        {
            Generation = 1;
            PopulationSize = populationSize;
            TotalGenerations = totalGenerations;
            MutationRate = mutationRate;
            Joypad = joypad;
            Population = new List<Species>(populationSize);
            for (int index = 0; index < populationSize; index++)
            {
                Population.Add(new Species(index));
            }
        }

        public void FitnessFunction(Species species, StepResponse step)
        {
            int diffScore = ((int)step.Info.Score - prevScore) / 10;
            prevScore = (int)step.Info.Score;
            species.Reward += step.Reward + diffScore;
            species.UpdateInformation(step);
        }

        private void RankingSelection()
        {
            Population.Sort((x, y)=> x.Reward.CompareTo(y.Reward));
        }

        private void Crossover(Species bestParent)
        {
            int resetId = 1;
            foreach (var species in Population)
            {
                species.Id = resetId++;
                species.Genes = bestParent.Genes.Select(gen => gen.Clone()).ToList();
                species.ResetSpecies();
            }
        }

        private void Mutation()
        {
            foreach(var species in Population)
            {
                int randomIndex = Utils.RandRange(0, species.Genes.Count);
                double probablity = Utils.RandRange(1, 100) / 100.0;
                if (probablity <= MutationRate)
                {
                    species.Genes[randomIndex] = Joypad.GetFrameActionSample();
                }
                //Modify the last 5 frames to prevent local optimum
                for (int i = 1; i <= 5; i++)
                {
                    var index = species.Genes.Count - i;
                    species.Genes[index] = Joypad.GetFrameActionSample(); ;
                }
            }
        }

        public Species NextSpecie()
        {
            
            if (currentSpecies == PopulationSize)
            {
                NextGeneration();
                currentSpecies = 0;
            }
            prevScore = 0;
            var specie = Population[currentSpecies];
            currentSpecies++;
            return specie;
        }

        private void NextGeneration()
        {
            RankingSelection();
            var bestSpecies = Population.Last();
            BestReward = bestSpecies.Reward;
            Crossover(bestSpecies);
            Mutation();
            Generation++;
        }
    }
}
