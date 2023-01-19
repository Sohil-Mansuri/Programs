using System;
using System.Collections.Generic;
using System.IO;

namespace MaximumCostOfLaptopCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int costCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> cost = new List<int>();

            for (int i = 0; i < costCount; i++)
            {
                int costItem = Convert.ToInt32(Console.ReadLine().Trim());
                cost.Add(costItem);
            }

            int labelsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> labels = new List<string>();

            for (int i = 0; i < labelsCount; i++)
            {
                string labelsItem = Console.ReadLine();
                labels.Add(labelsItem);
            }

            int dailyCount = Convert.ToInt32(Console.ReadLine().Trim());

            int result = MaxCost(cost, labels, dailyCount);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int MaxCost(List<int> cost, List<string> labels, int dailyCount)
        {
            int maxCost = 0;
            int currentDayCount = 0;
            int costStartIndex = 0;
            for (int labelsIndex = 0; labelsIndex < labels.Count; labelsIndex++)
            {

                if (labels[labelsIndex] == "legal")
                    currentDayCount++;

                if (dailyCount == currentDayCount)
                {
                    int currentMaxCost = 0;
                    for (int costIndex = costStartIndex; costIndex <= labelsIndex; costIndex++)
                    {
                        currentMaxCost += cost[costIndex];
                    }

                    if (currentMaxCost > maxCost)
                        maxCost = currentMaxCost;

                    currentDayCount = 0;
                    costStartIndex = labelsIndex + 1;
                }
            }

            return maxCost;
        }
    }
}
