using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace SortAndSearch
{
    public class DataImport
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
    
    public class BubbleSort
        {
            public static void Sorting(string[] IntList)
            { 
            
                int length = IntList.Length;
                for (int x = 0; x < length; x++)
                {
                    for (int y = 0; y < length - x; y++)
                    {
                        if (IntList[x] > IntList[y+1])
                        {
                            int cache = IntList[x];
                            IntList[x] = IntList[y];
                            IntList[y] = cache;


                        }


                    }


                }

            }


        }




        public static void Main(string[] args)
        {
            Console.WriteLine("Test");
            string[] ArrayList = ChooseFile();
            int[] IntList = Array.ConvertAll(ArrayList, int.Parse);

         





        }
      
        
        
    }
    






}


