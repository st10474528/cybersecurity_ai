using System;

namespace cybersecurity_ai
{
    public class welcoming_user
    {

        //global variable to store username
        private string username = string.Empty;

        //void method to welcome the user
        //void method to welcome the user
        public void welcome()
        {
            //message to the user with text color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("       [ Welcome ChatBot ]      ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------");

            //reset color
            Console.ResetColor();
        }

        //method to ask the user name
        public void ask_user()
        {
            //AI message and name with text color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("NECH: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter your name..");

            //reset the color
            Console.ResetColor();

            //do while to re-prompt the user for username
            do
            {
                //prompt and test color
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("USER: ");

                Console.ForegroundColor = ConsoleColor.Cyan;
                username = Console.ReadLine();

            } while (!empty());
        }

        //Boolean method to check the username is not empty
        public Boolean empty()
        {
            //checking if username is not empty using if statement
            if (username != "")
            {
                //success message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("NECH: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hey, " + username);

                //return true
                return true;
            }
            else
            {
                //error message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("NECH: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter name...");

                //return false
                return false;
            }
        }

        // Add this method to the welcoming_user class
        public string get_username()
        {
            return username;
        }

    }
}