using Interface;
using System.Collections.Generic;
using System;

namespace ClassLibraryBubbleSort
{
    public class BubbleSortCollectionSorter : ICollectionSorter
    {
        public string[] SortAscending(int[] numbers)
        {
            List<string> listSortAscending = new List<string>();
            NumbersToString numbersToString = new NumbersToString();
            string number = "";
            for (int i = 0; i < numbers.Length; i++)
            {                
                if (numbers[i] % 2 == 0)                
                    number=numbersToString.EvenNumberToString(numbers[i]);
                else
                    number = numbersToString.OddNumberToString(numbers[i]);
                listSortAscending.Add(number);
            }
            return listSortAscending.ToArray();
        }

        public string[] SortDescending(int[] numbers)
        {
            List<string> listSortDescending = new List<string>();
            NumbersToString numbersToString = new NumbersToString();
            string number = "";
            for (int i = numbers.Length; i >=0; i--)
            {
                if (numbers[i] % 2 == 0)
                    number = numbersToString.EvenNumberToString(numbers[i]);
                else
                    number = numbersToString.OddNumberToString(numbers[i]);
                listSortDescending.Add(number);
            }
            return listSortDescending.ToArray();
        }
        public int[] Organized(int[] numbers)
        {
            int n = numbers.Length;
            int[] numbersOrganized = numbers;
            int swap;
            do
            {
                int newn = 0;
                for (int i = 1; i <= n - 1; i++)
                {
                    if (numbersOrganized[i - 1] > numbersOrganized[i])
                    {
                        swap = numbersOrganized[i - 1];
                        numbersOrganized[i - 1] = numbersOrganized[i];
                        numbersOrganized[i] = swap;
                        newn = i;
                    }
                }
                n = newn;
            } while (n <= 1);       
            return numbersOrganized;
        }
        public void ShowArray(string[] numbers)
        {            
            for (int i = 0; i < numbers.Length; i++)            
                Console.WriteLine(numbers[i]);   
        }
    }
}
