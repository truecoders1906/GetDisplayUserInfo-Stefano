using System;

namespace GetUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the following information.");
            Console.Write("What is your first name");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name");
            string lastName = Console.ReadLine();

            Console.Write("What is your favorite number");
            int favNumber = Console.ReadLine();

            Console.WriteLine("Do you have any pets?");
			Console.Write("Please reply with:  \"yes\" or \"no\"");
            string doYouHavePets = Console.ReadLine();

            Console.WriteLine("How many pets do you have?");
            Console.Write("Please answer with a number: ");
            int numberOfPets = Console.ReadLine();

            Console.Write("What is your first name");
            string nameOfPets = Console.ReadLine();


        }
    }
}






/*
4. Using C# classes to implement, ask the user for information about themselves:
    - First Name
    - Last Name
    - Favorite Number
    - Number of Pets
    - Names of All Pets
    - Any other information you want to ask about
5. After getting all their information, display it back to them as sentences,
    such as "Hello, John Doe.", "Your favorite number is 2.", etc.)
6. Submit a pull request to merge your changes to the `master` branch
*/