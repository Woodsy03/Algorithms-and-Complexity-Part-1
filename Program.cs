using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace SortAndSearch
{
    public class SortAlgorithm
    {
        private static string[] ChooseFile()
        {
            string[] Road_1_256 = new WebClient().DownloadString("https://raw.githubusercontent.com/Woodsy03/Algorithms-and-Complexity-Part-1/master/Road_1_256.txt").Split('\n');
            string[] Road_2_256 = new WebClient().DownloadString("https://raw.githubusercontent.com/Woodsy03/Algorithms-and-Complexity-Part-1/master/Road_2_256.txt").Split('\n');
            string[] Road_3_256 = new WebClient().DownloadString("https://raw.githubusercontent.com/Woodsy03/Algorithms-and-Complexity-Part-1/master/Road_3_256.txt").Split('\n');
            string[] Road_1_2048 = new WebClient().DownloadString("https://raw.githubusercontent.com/Woodsy03/Algorithms-and-Complexity-Part-1/master/Road_1_2048.txt").Split('\n');
            string[] Road_2_2048 = new WebClient().DownloadString("https://raw.githubusercontent.com/Woodsy03/Algorithms-and-Complexity-Part-1/master/Road_2_2048.txt").Split('\n');
            string[] Road_3_2048 = new WebClient().DownloadString("https://raw.githubusercontent.com/Woodsy03/Algorithms-and-Complexity-Part-1/master/Road_3_2048.txt").Split('\n');

            /*
            This code was the initial local solution but I opted for a direct download as that allows data hot swapping and allows the same files to be pulled from multiple machines simultaniously (which a local data file can't do)
            string[] Road_1_256 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_1_256.txt");
            string[] Road_2_256 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_2_256.txt");
            string[] Road_3_256 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_3_256.txt");
            string[] Road_1_2048 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_1_2048.txt");
            string[] Road_2_2048 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_2_2048.txt");
            string[] Road_3_2048 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_3_2048.txt");
            */

            while (true)
            {
                Console.WriteLine("Which Road-Map would you like to import? (You can choose 1, 2 or 3 for the 256 part roads or 4, 5 or 6 for the 2048 part roads respectively. You may also choose 7 for a merged 256 part road or 8 for a merged 2048 part road)");
                string ChosenPath = Console.ReadLine();
                if (ChosenPath == "1" || ChosenPath == "2" || ChosenPath == "3" || ChosenPath == "4" || ChosenPath == "5" || ChosenPath == "6" || ChosenPath == "7" || ChosenPath == "8")
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
                    else if (ChosenPath == "3")
                    {
                        return Road_3_256;
                    }
                    else if (ChosenPath == "4")
                    {
                        return Road_1_2048;
                    }
                    else if (ChosenPath == "5")
                    {
                        return Road_2_2048;
                    }
                    else if (ChosenPath == "6")
                    {
                        return Road_3_2048;
                    }
                    else if (ChosenPath == "7")
                    {
                        string[] Road_256_merged = Road_1_256.Concat(Road_3_256).ToArray();
                        return Road_256_merged;
                    }
                    else
                    {
                        string[] Road_2048_merged = Road_1_2048.Concat(Road_3_2048).ToArray();
                        return Road_2048_merged;
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
                int midpoint = 0;
                int min = 0;
                while (min <= max)
                {
                    midpoint = (max + min) / 2;
                    //Console.WriteLine("midpoint is " + midpoint + " and the value is " + IntList[midpoint]);
                    if (max < UserInput)
                    {
                        Console.WriteLine("The provided search query was too high to be in this list.");
                        midpoint = 0;
                        return midpoint;

                    }
                    else if (UserInput == IntList[midpoint])
                    {
                        return midpoint;
                    }
                    else if (IntList[midpoint] < UserInput)
                    {
                        min = midpoint +1;
                    }
                    else if (IntList[midpoint] > UserInput)
                    {
                        max = midpoint - 1;
                    }
                }

                midpoint = midpoint * -1;
                return midpoint;
            }
        }


        public static void Main(string[] args)
        {
            string[] ArrayList = ChooseFile();
            int[] IntList = BubbleSort(ArrayList);

            int[] DescendngIntList = IntList;
            Array.Reverse(DescendngIntList);
            // Use the sorted array as needed
            int i = 0;
            int SpacingVariable = 0;
            Console.WriteLine("this is displaying every " + SpacingVariable + "th line from the ascending order list");
            if (IntList.Length <= 600)
            {
                SpacingVariable = 10;
            }
            else
            {
                SpacingVariable = 50;
            }

            foreach (int x in IntList)
            {
                i = i + 1;
                if (i %(SpacingVariable) == 0)
                {
                    Console.WriteLine("line " + i + " has the number "+ (x)); //x+1 is used to offset the index starting at 0

                }
                
            }

            i = 0;
            Console.WriteLine("this is displaying every 10th line from the descending order list");
            foreach (int x in DescendngIntList)
            {
                i = i + 1;
                if (i %(SpacingVariable) == 0)
                {
                    Console.WriteLine("line " + i + " has the number " + (x)); //x+1 is used to offset the index starting at 0

                }

            }

            Console.WriteLine("Which entry would you like to search for?");
            Array.Reverse(IntList);
            int UserInput = int.Parse(Console.ReadLine());
            int ReturnedPhrase = SearchAlgorithm.BinarySearch(IntList, UserInput);
            int FlippedPhrase = Math.Abs(ReturnedPhrase);
            if (ReturnedPhrase <= -1)
            {
                ReturnedPhrase = Math.Abs(ReturnedPhrase);
                Console.WriteLine("The entry " + UserInput + " could not be found in this list. The closest value was on line " + FlippedPhrase);
            }
            else
            {
                Console.WriteLine("The entry " + UserInput + " was found on line " + ReturnedPhrase);
            }

        }
    }
}
