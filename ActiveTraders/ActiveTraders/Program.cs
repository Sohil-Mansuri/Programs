using System;
using System.Collections.Generic;
using System.Linq;

namespace ActiveTraders
{
    class Program
    {
        static void Main(string[] args)
        {
            int customersCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> customers = new List<string>();

            for (int i = 0; i < customersCount; i++)
            {
                string customersItem = Console.ReadLine();
                customers.Add(customersItem);
            }

            List<string> result = MostActive(customers);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }


        public static List<string> MostActive(List<string> customers)
        {
            Dictionary<string, int> customerCount = new Dictionary<string, int>();
            for (int index = 0; index < customers.Count; index++)
            {
                if (customerCount.ContainsKey(customers[index]))
                {
                    customerCount[customers[index]]++;
                }
                else
                {
                    customerCount[customers[index]] = 1;
                }
            }

            List<string> result = new List<string>();
            foreach (var item in customerCount)
            {
                float percentage = (float)item.Value / (float)customers.Count * 100;

                if (percentage < 5)
                {
                    result.Add(item.Key);
                }        
            }

            return result.OrderBy(o => o).ToList();
        }
    }
}
