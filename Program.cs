using System.Collections;
using System.IO;

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
            public static void Sorting(string[] ArrayList) 
            { 
            


            }


        }




        public static void Main(string[] args)
        {
            Console.WriteLine("Test");
            string[] ArrayList = ChooseFile();

         





        }
      
        
        
    }
    






}


