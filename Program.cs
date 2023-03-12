namespace SortAndSearch
{
    class DataImport
    {
        public DataImport(string Road_1_256)
        {
            string[] Road_1_256 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_1_256.txt");
            string[] Road_2_256 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_2_256.txt");
            string[] Road_3_256 = File.ReadAllLines("C:\\Users\\xbox2\\Desktop\\Uni Work\\Year 1\\Problem Solving\\Road_3_256.txt");

        }
    }
    class BubbleSort
    {
        static void Main()
        {
            string ValidPath = "false";

            while (ValidPath is "false")
            {
                Console.WriteLine("Which Road 256 map would you like to sort? (1, 2 or 3)");
                string ChosenPath = Console.ReadLine();
                if (ChosenPath is "1" or "2" or "3")
                {
                    Console.WriteLine("You have chosen RoadMap number " + ChosenPath);
                    ValidPath = "true";
                }
                else
                {
                    Console.WriteLine("That isn't a valid option, please try again.");
                }
            }
      
        
        
        }
    }






}


