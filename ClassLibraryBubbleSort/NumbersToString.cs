using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryBubbleSort
{
    public class NumbersToString
    {
        public Dictionary<int,string> OddNumbers { get; set; }
        public Dictionary<int, string> EvenNumbers { get; set; }
        public NumbersToString()
        {
            initializeOddNumers();
            initializeEvenNumers();
        }
        private void initializeOddNumers()
        {
            for (int i = 1; i <= 9; i += 2)
            {
                switch (i)
                {
                    case 1:
                        OddNumbers.Add(i, "ONE");
                        break;
                    case 3:
                        OddNumbers.Add(i, "THREE");
                        break;
                    case 5:
                        OddNumbers.Add(i, "FIVE");
                        break;
                    case 7:
                        OddNumbers.Add(i, "SEVEN");
                        break;
                    case 9:
                        OddNumbers.Add(i, "NINE");
                        break;
                }
            }
        }
        private void initializeEvenNumers()
        {
            for (int i = 0; i <= 8; i += 2)
            {
                switch (i)
                {
                    case 0:
                        OddNumbers.Add(i, "ZeRo");
                        break;
                    case 2:
                        OddNumbers.Add(i, "two");
                        break;
                    case 4:
                        OddNumbers.Add(i, "four");
                        break;
                    case 6:
                        OddNumbers.Add(i, "six");
                        break;
                    case 8:
                        OddNumbers.Add(i, "eight");
                        break;
                }
            }
        }
        public string OddNumberToString(int number)
        {
            foreach(var target in OddNumbers)
            {
                if (target.Key == number)
                    return target.Value;
            }
            return number.ToString();
        }
        public string EvenNumberToString(int number)
        {
            foreach (var target in EvenNumbers)
            {
                if (target.Key == number)
                    return target.Value;
            }
            return number.ToString();
        }
    }
}
