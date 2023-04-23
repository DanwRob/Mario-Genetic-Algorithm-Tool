﻿using GeneticAlgorithmTool.Models;
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
        private int prevScore = 0;
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

        //public void FitnessFunction(Species species)
        //{
        //    //int diffScore = (int)((stepInfo.Info.Score - species.Info.Score) / 10);
        //    //species.Score += stepInfo.Reward + diffScore;
        //    //if (currentFrame.IsFinishAction())
        //    //{
        //    //    int diffScore = (int) ((stepInfo.Info.Score - species.Info.Score ) / 10);
        //    //    //int diffTime = (int)(stepInfo.Info.Time - species.Info.Time);
        //    //    int diffTime = 0;
        //    //    species.Score += diffScore + diffTime;
        //    //}
        //    //species.UpdateInformation(stepInfo);
        //    int diffScore = 0;
        //    int prevScore = 0;
        //    foreach (var gen in species.Genes)
        //    {
        //        prevScore = (gen.Score - prevScore)/10;
        //        diffScore += prevScore;
        //    }
        //    species.Reward += diffScore;
        //}

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
                //Modify the last 5 frames to prevent local optimum
                for (int i = 1; i < 5; i++)
                {
                    species.Genes[species.Genes.Count - i] = Joypad.GetFrameActionSample();
                }
            }
        }

        public Species BestScore() => Population.Last();

        public Species NextSpecie()
        {
            
            if (currentSpecies == PopulationSize)
            {
                NextGeneration();;
                currentSpecies = 0;
                prevScore = 0;
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