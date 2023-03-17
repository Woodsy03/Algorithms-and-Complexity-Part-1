using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net.Http.Headers;

namespace SortAndSearch
{
    public class SortAlgorithm
    {
        private static string[] ChooseFile()
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
            public static int BinarySearch(int[] IntList, int UserInput)
            {
                Console.WriteLine("We are searching for the string " + UserInput);
                int max = IntList.Length;
                int min = 0;
                while (min < max)
                {
                    int midpoint = (max + min) / 2;
                    Console.WriteLine("midpoint is " + midpoint + " and the value is " + IntList[midpoint]);
                    if (UserInput == IntList[midpoint])
                    {
                        return midpoint;
                    }
                    else if (IntList[midpoint] < UserInput)
                    {
                        min = midpoint - 1;
                    }
                    else if (IntList[midpoint] > UserInput)
                    {
                        max = midpoint;
                    }

                }
                return -1;
            }
        }


        public static void Main(string[] args)
        {
            string[] ArrayList = ChooseFile();
            int[] IntList = BubbleSort(ArrayList);

            // Use the sorted array as needed
            int i = 0;
            foreach (int x in IntList)
            {
                i = i + 1;
                if (i %10 == 0)
                {
                    Console.WriteLine("line " + i + " has the number "+ (x+1)); //x+1 is used to offset the index starting at 0

                }
                
            }

            Console.WriteLine("Which entry would you like to search for?");
            int UserInput = int.Parse(Console.ReadLine());
            int ReturnedPhrase = SearchAlgorithm.BinarySearch(IntList, UserInput);
            Console.WriteLine("returned phrase is " + ReturnedPhrase);
            if (ReturnedPhrase == -1)
            {
                Console.WriteLine("The entry " + UserInput + " could not be found in this list");
            }
            else
            {
                Console.WriteLine("The entry " + UserInput + " was found on line " + ReturnedPhrase);
            }

        }
    }
}
