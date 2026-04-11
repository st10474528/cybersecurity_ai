using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cybersecurity_ai
{
    public class Program
    {
        static void Main(string[] args)
        {

            //creating an instance of audio_greeting with constructor
            new audio_greeting();

            //creating an instance of ascii_art with constructor
            new arcii_art();

            //creating an instance of welcoming_user class with object name welcome_and_collect
            welcoming_user welcome_and_collect = new welcoming_user();

            //calling the welcome() method
            welcome_and_collect.welcome();


            //calling the ask_user() method
            welcome_and_collect.ask_user();

            // Get the username from the welcome class
            string userName = welcome_and_collect.get_username();

            //creating an instance of chatbot_responce with object name respond
            chatbot_responce respond = new chatbot_responce(userName);
        }
    }
}
