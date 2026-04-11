using System;
using System.IO;
using System.Media;

namespace cybersecurity_ai
{
    public class audio_greeting
    {
        public audio_greeting()
        {

            //calling the greet() method
            greet();

        }

        //method to play the voice
        private void greet()
        {//start of greet() method

            //try statement to catch any exception that may occur while playing the audio
            try
            {//start of try statement

                //getting the base directory of the application
                string paths = AppDomain.CurrentDomain.BaseDirectory;

                //replacing the path to get the full path of the audio file
                string fullpath = paths.Replace(@"bin\Debug\", "greeting.wav.wav");

                //creating an instance of SoundPlayer class to play the audio
                SoundPlayer voice_play = new SoundPlayer(fullpath);

                //Loading the audio
                voice_play.Load();

                //Playing the audio
                voice_play.Play();

            }//end of try statement
            catch (FileNotFoundException ex)
            {//start of catch statement

                //setting the color to red to indicate an error
                Console.ForegroundColor = ConsoleColor.Red;

                //catching the exception if the audio file is not found and printing the message
                Console.WriteLine($"Audio file not found: {ex.Message}");

                //resetting the color
                Console.ResetColor();

            }//end of catch statement

        }//end of greet method
    }
}