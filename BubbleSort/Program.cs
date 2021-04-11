using System;
using ClassLibraryBubbleSort;
namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo op;

            do
            {
                Console.Clear(); //Limpiar la pantalla
                Console.WriteLine("Bobble Sort Method");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[A] Sort Ascending");
                Console.WriteLine("[B] Sort Descending");                
                Console.WriteLine("[Esc] Salir");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Select option...");
                op = Console.ReadKey(true);//Que no muestre la tecla señalada

                //métodos son acciones, las propiedades son valores
                switch (op.Key)
                {
                    case ConsoleKey.A:
                        var arrayA = RandomArray();
                        BubbleSortCollectionSorter bubbleSortCollectionSorter = new BubbleSortCollectionSorter();
                        bubbleSortCollectionSorter.ShowArray(bubbleSortCollectionSorter.SortAscending(arrayA));                       
                        break;

                    case ConsoleKey.B:
                        var arrayD = RandomArray();
                        BubbleSortCollectionSorter bubbleSortCollectionSorterD = new BubbleSortCollectionSorter();
                        bubbleSortCollectionSorterD.ShowArray(bubbleSortCollectionSorterD.SortDescending(arrayD));                       
                        break;                   

                    case ConsoleKey.Escape:
                        Console.WriteLine("Bye");

                        break;
                }
            } while (op.Key != ConsoleKey.Escape);
        }
        public static int[] RandomArray()
        {
            int number = 0;
            bool isNumber = false;
            do
            {
                try
                {
                    Console.WriteLine("Please insert vector size (only numbers):");
                    number = Convert.ToInt32(Console.ReadLine());
                    isNumber = true;
                }
                catch
                {
                    isNumber = false;
                }
            } while (!isNumber);
            Random random = new Random();
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(0, 99) + 1;
            return array;
        }
    }
}
