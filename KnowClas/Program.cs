using System;

namespace KnowClas
{
    class Program
    {
        private static void Main(string[] args,)
        {
            string[] Names = { "Kyle", "Anthony", "Kobe", "Jada" };
            string[] HomeTown = { "Battle Creek", "Detroit", "Los Angeles", "Chicago" };
            string[] FavoriteFood = { "Hamburgers", "Cheese Fries", "Lamb Chops", "Salad" };

            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine($"{i + 1,-10}{Names[i],-15}{HomeTown[i],-15}{FavoriteFood[i]}");
            }

            int StudentProfile = int.Parse(GetUserInput($"Which Student would you like to learn about? PLease enter a number between 1 & 4."));
            StudentProfile = VerifyStudent(" Sorry the number you enter is not a option. Please enter a number between 1 & 4.", StudentIndex);
            Console.WriteLine($"Student #{StudentIndex} is {Names[StudentIndex - 1]}.");

            string UserInterest = GetUserInput($"Do you want to know about {Names[StudentIndex - 1]}'s favorite food or hometown?");
            UserInterest = VerifyUserIntrest(UserInterest, $"Please type 'hometown' or 'favorite food' to find out more about {Names[StudentIndex - 1]}.");

            if (UserChoice == "favorite food")
            {
                Console.WriteLine($"{Names[StudentIndex - 1]}'s favorite food is {FavoriteFoods[StudentIndex - 1]}");
            }
            else if (UserChoice == "hometown")
            {
                Console.WriteLine($"{Names[StudentIndex - 1]}'s Hometown is {HomeTown[StudentIndex - 1]}");
            }
            if (!UserRt("Do you want to continue learning about the students?"))
            {
                return;
            }
            else
            {
                KnowYourClassmates();
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }

        public static int VerifyStudent(string messge, int StudentIndex, bool message, int StudentProfile)
        {
            while (StudentProfile < 1 && StudentProfile > 4)
            {
                Console.WriteLine(message);
                StudentProfile = int.Parse(Console.ReadLine());
            }
            return StudentProfile;
        }

        public static string VerifyUserIntrest(string UserIntrest, string message, string UserInterest)
        {
            while (UserIntrest != "hometown" && UserIntrest != "favorite food")
            {
                Console.WriteLine(message);
                UserIntrest = Console.ReadLine();
            }
            return UserIntrest;
        }
        public static bool UserRt(string message, string Response)
        {
            Console.WriteLine(message);
            String sentence = Console.ReadLine().ToUpper;

            while (Response != "Y" && Response != "N")
            {
                Console.WriteLine(" Do you wish to learn about another student? Please enter Y/N.");
                Response = Console.ReadLine();
            }
            if (Response == "N")
            {
                Console.WriteLine("Okay goodbye.");
                return false;
            }
            else

                return true;
        }
    }
}
