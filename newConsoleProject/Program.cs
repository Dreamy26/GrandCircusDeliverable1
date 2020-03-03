using System;

namespace newConsoleProject
{
    class Program
    {

        public static void Main(string[] args){
        
            Console.WriteLine("What type of Vacation would you like to go on? (Musical, Tropical, or Adventurous)");
            string vacationType = Console.ReadLine();

            Console.WriteLine("How many will be in your Group");
            int groupSize = int.Parse(Console.ReadLine());

            string destination;

            if (vacationType.Equals("Musical"))
            {
                destination = "New Orleans";
            }
            else if (vacationType.Equals("Tropical"))
            {
                destination = "Beach Vacation in Mexico";
            }
            else if (vacationType.Equals("Adventurous"))
            {
                destination = "White Water Rafting the Grand Canyon";
            } else
            {
                destination = "";
            }

            string travelSuggestion;

            if (groupSize >= 1 && groupSize <= 2)
            {
                travelSuggestion = "First Class";
            }
            else if (groupSize >= 3 && groupSize <= 5)
            {
                travelSuggestion = "Helicopter";
            }
            else
            {
                travelSuggestion = "Charter Flight";
            }

            string result = "Since your a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " + travelSuggestion + " to a " + destination;

            Console.WriteLine(result);
        }

    }
}















