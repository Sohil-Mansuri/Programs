using System;
using System.Collections.Generic;

namespace ExNorOperation
{
    /// <summary>
    /// Problem : {A , B , C , D} ExNor { B , G , T,  D , E } = { A , C , G , T, E }
    /// Non Common Elements
    /// Why Dictionary Used ? : it is fater to search into if you have key : T(n) = O(1) for searching 
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
             string[] inputA = { "A", "V", "C", "B", "A", "M", "B" };
             string[] inputB = { "H", "A", "T", "V", "Y", "Y" };

            var operation = new ExNorOperationUtil(inputA, inputB);

            //convert input to Dictionary
            var disA = operation.ConvertToDictionary(inputA);   // O(n)
            var disB = operation.ConvertToDictionary(inputB);   // O(n)

            var result = operation.ExNorOperation(disA, disB);  //O(n)

            //so overall time complexity= O(n) + O(n) + O(n) = O(n)

        }
    }

    public class ExNorOperationUtil
    {
        private string[] inputA = null;
        private string[] inputB = null;

        public ExNorOperationUtil(string[] inputA,string[] inputB)
        {
            this.inputA = inputA;
            this.inputB = inputB;
        }
        public Dictionary<string, int> ConvertToDictionary(string[] input)  //O(n)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i++)
            {
                //already exist then increment its frequency
                if (dictionary.ContainsKey(input[i]))
                    dictionary[input[i]]++;
                else
                    dictionary[input[i]] = 1;
            }
            return dictionary;
        }

        public Dictionary<string, int> ExNorOperation(Dictionary<string, int> disA, Dictionary<string, int> disB)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            //take all element of inputA and search in dicB if present then ignore   // O(n)
            for (int i = 0; i < inputA.Length; i++)
            {
                if (disB.ContainsKey(inputA[i]))            //O(1)
                    continue;
                else
                    result[inputA[i]] = disA[inputA[i]]; //to get frequency
            }

            //take all element of inputB and search in disA if present then ignore else insert in result O(n)
            for (int i = 0; i < inputB.Length; i++)
            {
                if (disA.ContainsKey(inputB[i]))           //O(1)
                    continue;
                else
                    result[inputB[i]] = disB[inputB[i]]; //to get frequency
            }

            //Time Complexity = O(n) + O(n) = O(n)

            return result;
        }

    }
}
