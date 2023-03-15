using System;
using System.IO;

namespace SortAndSearch
{
    public class SortAlgorithm
    {
        public static string[] ChooseFile()
        {
            string[] Road_1_256 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_1_256.txt");
            string[] Road_2_256 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_2_256.txt");
            string[] Road_3_256 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_3_256.txt");

            while (true)
            {
                Console.WriteLine("Which Road-Map would you like to import? (You can choose 1, 2 or 3)");
                string ChosenPath = Console.ReadLine();
                if (ChosenPath == "1" || ChosenPath == "2" || ChosenPath == "3")
                {
                    Console.WriteLine("You have chosen RoadMap number " + ChosenPath);
                    if (ChosenPath == "1")
                    {
                        return Road_1_256;
                    }
                    else if (ChosenPath == "2")
                    {
                        return Road_2_256;
                    }
                    else
                    {
                        return Road_3_256;
                    }
                }
                else
                {
                    Console.WriteLine("That isn't a valid option, please try again.");
                }
            }
        }

        public static int[] BubbleSort(string[] stringArray)
        {
            int length = stringArray.Length;
            int[] intArray = Array.ConvertAll(stringArray, int.Parse);

            for (int x = 0; x < length; x++)
            {
                for (int y = x + 1; y < length; y++)
                {
                    if (intArray[x] > intArray[y])
                    {
                        int cache = intArray[x];
                        intArray[x] = intArray[y];
                        intArray[y] = cache;
                    }
                }
            }
            return intArray;
        }

    public class SearchAlgorithm
        {
            public static string UserInputSearch(int[] IntList, string UserInput)
            {
                Console.WriteLine("We are searching for the string " + UserInput);

            }


        }


        public static void Main(string[] args)
        {
            string[] ArrayList = ChooseFile();
            int[] IntList = BubbleSort(ArrayList);

            // Use the sorted array as needed
            foreach (int x in IntList)
            {
                if (x %10 == 0)
                {
                    Console.WriteLine(x);
                }
                
            }

            Console.WriteLine("Which entry would you like to search for?");
            string UserInput = Console.ReadLine();
            string ReturnedPhrase = UserInputSearch(IntList, UserInput);
        }
    }
}
