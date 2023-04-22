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
        private int currentSpecies = 0;

        public GeneticAlgorithm(int totalGenerations, int populationSize, JoypadSpace joypad)
        {
            Generation = 1;
            PopulationSize = populationSize;
            TotalGenerations = totalGenerations;
            Joypad = joypad;
            Population = new List<Species>(populationSize);
            for (int index = 0; index < populationSize; index++)
            {
                Population.Add(new Species(index));
            }
        }

        public void FitnessFunction(int reward, Species species)
        {
            int gameScore = (int)species.Info.Score;
            species.Score += reward + (gameScore / 10);
        }

        private void RankingSelection()
        {
            Population.Sort((x, y)=> x.Score.CompareTo(y.Score));
        }

        private void Crossover(Species bestParent)
        {
            foreach (var species in Population)
            {
                species.Genes = bestParent.Genes.ConvertAll(gen => gen.Clone()).ToList();
                species.ResetSpecies();
            }
        }

        private void Mutation()
        {
            foreach(var species in Population)
            {
                int randomIndex = Utils.RandRange(0, species.Genes.Count);
                species.Genes[randomIndex] = Joypad.GetFrameActionSample();
            }
        }

        public Species BestScore() => Population.Last();

        public Species NextSpecie()
        {
            
            if (currentSpecies == PopulationSize)
            {
                NextGeneration();
                currentSpecies = 0;
            }
            var specie = Population[currentSpecies];
            currentSpecies++;
            return specie;
        }

        private void NextGeneration()
        {
            RankingSelection();
            Crossover(Population.Last());
            Mutation();
            Generation++;
        }
    }
}
