using System;

namespace GeneticAlgorithmTool
{
    public static class Utils
    {
        public static int RandRange(int start, int stop, int step = 1)
        {
            var random = new Random();
            return (random.Next(start, stop) * step) - (step - 1);
        }
    }
}
