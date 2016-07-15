using System;
using System.Windows.Forms;
namespace Random_password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables with characters to use for the password and making an array out of the string 
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string specChar = "!#$%&'()*+-/:;<=?@[_{|~";
            string allCharacters = letters + specChar;
            char[] lettersArr = letters.ToCharArray();
            char[] allCharactersArr = allCharacters.ToCharArray();
            string password = "";

            Console.WriteLine("***************************************************");
            Console.WriteLine("             RANDOM PASSWORD GENERATOR            ");
            Console.WriteLine("***************************************************");
            // User input to determine how the password will be and if special characters will be added or not
            Console.Write("Enter number of characters: ");
            int numOfChar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of passwords: ");
            int numOfPAss = Convert.ToInt32(Console.ReadLine());
            Console.Write("Special Characters? (Y/N): ");
            string userInp = Console.ReadLine().ToUpper();

            // Running the GeneratoPassword method with just string letters or string allCharacters
            if (userInp == "Y")
                password = GeneratePassword(numOfPAss, password, numOfChar, allCharacters, allCharactersArr);
            else
                password = GeneratePassword(numOfPAss, password, numOfChar, letters, lettersArr);

            // Print password
            Console.WriteLine("\nPassword: " + "\n\n" + password);
            Console.ReadKey();
        }

        // Method that generates a random password taking as parameters the number of characters, the string and array to reference
        // The Random method is used to select a random character from the array and then added to the string password
        static string GeneratePassword(int numOfPass, string password, int numberOfCharacters, string charactersToUse, char[] ArrayToUse)
        {
            Random rand = new Random();
            for (int i = 0; i < numOfPass; i++)
            {
                for (int y = 0; y < numberOfCharacters; y++)
                {
                    password += Convert.ToString(ArrayToUse[rand.Next(0, charactersToUse.Length - 1)]);
                }

                password += "\n";
            }
            return password;
        }
    }
}
