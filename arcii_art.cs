using System;
using System.Threading;

namespace cybersecurity_ai
{
    public class arcii_art
    {
        public arcii_art()
        {

            //calling the display_header() method
            display_header();
        }

        public static void display_header()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string asciiArt = @"
    ╔══════════════════════════════════════════════════════════════════════════════╗
    ║                                                                              ║
    ║    ███╗   ██╗███████╗ ██████╗██╗  ██╗    ██████╗  ██████╗ ████████╗         ║
    ║    ████╗  ██║██╔════╝██╔════╝██║  ██║    ██╔══██╗██╔═══██╗╚══██╔══╝         ║
    ║    ██╔██╗ ██║█████╗  ██║     ███████║    ██████╔╝██║   ██║   ██║            ║
    ║    ██║╚██╗██║██╔══╝  ██║     ██╔══██║    ██╔══██╗██║   ██║   ██║            ║
    ║    ██║ ╚████║███████╗╚██████╗██║  ██║    ██████╔╝╚██████╔╝   ██║            ║
    ║    ╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝    ╚═════╝  ╚═════╝    ╚═╝            ║
    ║                                                                              ║
    ║                      🛡️  CYBERSECURITY AWARENESS BOT  🛡️                       ║
    ║                                                                              ║
    ╚══════════════════════════════════════════════════════════════════════════════╝";

            Console.WriteLine(asciiArt);
            Console.ResetColor();
            Thread.Sleep(1000);
        }

    }
}