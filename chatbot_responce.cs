using System;
using System.Threading;

namespace cybersecurity_ai
{
    public class chatbot_responce
    {
        private string userName;
        private bool isRunning;

        // Constructor that accepts the username
        public chatbot_responce(string name)
        {
            userName = name;
            isRunning = true;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n============================================================");
            Console.WriteLine("I can help you with cybersecurity topics!");
            Console.WriteLine("============================================================");
            Console.ResetColor();

            StartConversation();
        }

        private void StartConversation()
        {
            DisplayHelpMenu();

            while (isRunning)
            {
                // Get user input
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\nYOU: ");
                Console.ResetColor();

                string userInput = Console.ReadLine();

                // Check if user wants to exit
                if (IsExitCommand(userInput))
                {
                    SayGoodbye();
                    break;
                }

                // Validate input
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    EmptyInputResponse();
                    continue;
                }

                // Process and display response
                string response = ProcessInput(userInput);
                DisplayResponse(response);
            }
        }

        private void DisplayHelpMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("                  WHAT YOU CAN ASK ME:                  ");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("  - 'How are you?'                                       ");
            Console.WriteLine("  - 'What is your purpose?'                             ");
            Console.WriteLine("  - 'What can I ask you about?'                         ");
            Console.WriteLine("  - 'Tell me about password safety'                     ");
            Console.WriteLine("  - 'How to spot phishing emails?'                      ");
            Console.WriteLine("  - 'Safe browsing tips'                                ");
            Console.WriteLine("  - 'Type 'quit' or 'exit' to end'                      ");
            Console.WriteLine("---------------------------------------------------------");
            Console.ResetColor();
        }

        private string ProcessInput(string input)
        {
            string lowerInput = input.ToLower().Trim();

            // Greeting responses
            if (lowerInput.Contains("how are you") || lowerInput.Contains("how are ya") || lowerInput.Contains("how do you do"))
            {
                return GetGreetingResponse();
            }

            // Purpose responses
            if (lowerInput.Contains("purpose") || lowerInput.Contains("what do you do") || lowerInput.Contains("why do you exist") || lowerInput.Contains("your purpose"))
            {
                return GetPurposeResponse();
            }

            // Help / Questions response
            if (lowerInput.Contains("what can i ask") || lowerInput.Contains("what questions") || lowerInput.Contains("help") || lowerInput.Contains("what do you know"))
            {
                return GetHelpResponse();
            }

            // Password safety
            if (lowerInput.Contains("password") || lowerInput.Contains("passphrase") || lowerInput.Contains("secure password") || lowerInput.Contains("strong password"))
            {
                return GetPasswordTips();
            }

            // Phishing and scams
            if (lowerInput.Contains("phish") || lowerInput.Contains("scam") || lowerInput.Contains("fake email") || lowerInput.Contains("fraud") || lowerInput.Contains("suspicious email"))
            {
                return GetPhishingTips();
            }

            // Safe browsing / links
            if (lowerInput.Contains("brows") || lowerInput.Contains("website") || lowerInput.Contains("link") || lowerInput.Contains("url") || lowerInput.Contains("click") || lowerInput.Contains("online safety"))
            {
                return GetSafeBrowsingTips();
            }

            // Malware / viruses
            if (lowerInput.Contains("malware") || lowerInput.Contains("virus") || lowerInput.Contains("ransomware") || lowerInput.Contains("trojan"))
            {
                return GetMalwareTips();
            }

            // Social engineering
            if (lowerInput.Contains("social engineering") || lowerInput.Contains("manipulation") || lowerInput.Contains("trick"))
            {
                return GetSocialEngineeringTips();
            }

            // Two-factor authentication
            if (lowerInput.Contains("2fa") || lowerInput.Contains("two factor") || lowerInput.Contains("multi factor") || lowerInput.Contains("mfa"))
            {
                return Get2FATips();
            }

            // Default response for unrecognized input
            return GetDefaultResponse();
        }

        private string GetGreetingResponse()
        {
            string[] responses = {
                $"I'm doing great, thank you for asking, {userName}! I'm fully charged and ready to help you stay safe online!",
                $"I'm functioning perfectly, {userName}! As a cybersecurity bot, I'm always alert and ready to protect!",
                $"I'm excellent, {userName}! Thanks for checking in. How can I help you learn about cybersecurity today?"
            };
            Random rand = new Random();
            return responses[rand.Next(responses.Length)];
        }

        private string GetPurposeResponse()
        {
            return $"My purpose, {userName}, is to educate South African citizens about cybersecurity threats! \n\n" +
                   "I'm here to help you:\n" +
                   "- Recognize phishing emails and scams\n" +
                   "- Create and manage strong passwords\n" +
                   "- Browse the internet safely\n" +
                   "- Protect your personal information online\n" +
                   "- Avoid malware and ransomware attacks\n\n" +
                   "Together, we can make South Africa more cyber-safe!";
        }

        private string GetHelpResponse()
        {
            return "You can ask me about these cybersecurity topics:\n\n" +
                   "PASSWORD SAFETY - How to create and manage strong passwords\n" +
                   "PHISHING PROTECTION - How to spot fake emails and scams\n" +
                   "SAFE BROWSING - How to stay safe while surfing the web\n" +
                   "MALWARE PREVENTION - How to avoid viruses and ransomware\n" +
                   "SOCIAL ENGINEERING - How to spot manipulation tactics\n" +
                   "2FA / MFA - Two-factor authentication explained\n\n" +
                   "Just type your question naturally, and I'll help you out!";
        }

        private string GetPasswordTips()
        {
            return "PASSWORD SAFETY GUIDE\n\n" +
                   "DO's:\n" +
                   "- Use passwords that are at least 12-16 characters long\n" +
                   "- Include UPPERCASE, lowercase, numbers, and symbols (!@#$%)\n" +
                   "- Use a Password Manager (Bitwarden, LastPass, or 1Password)\n" +
                   "- Enable Two-Factor Authentication (2FA) whenever possible\n" +
                   "- Change passwords immediately if you suspect a breach\n\n" +
                   "DON'Ts:\n" +
                   "- Never reuse passwords across multiple accounts\n" +
                   "- Avoid using personal info (birthdays, pet names, ID numbers)\n" +
                   "- Don't use common passwords like 'password123' or 'qwerty'\n" +
                   "- Never share passwords via email or text message\n" +
                   "- Don't write passwords on sticky notes near your computer\n\n" +
                   "Example Strong Password: S@f3_Cyb3r_S4!th_Afr1c@2024\n" +
                   "Tip: Use passphrases like 'Blue-Sky-Mountain-Rain' with symbols!";
        }

        private string GetPhishingTips()
        {
            return "PHISHING SCAM DETECTION GUIDE\n\n" +
                   "RED FLAGS to watch for:\n" +
                   "- Urgent language: 'Your account will be closed TODAY!'\n" +
                   "- Spelling and grammar mistakes\n" +
                   "- Generic greetings like 'Dear Customer' (not your name)\n" +
                   "- Suspicious sender email addresses\n" +
                   "- Requests for passwords, ID numbers, or credit cards\n" +
                   "- Too-good-to-be-true offers or prizes\n\n" +
                   "WHAT TO DO:\n" +
                   "- NEVER click links in suspicious emails\n" +
                   "- Hover over links to see the real URL (don't click!)\n" +
                   "- Contact the company directly using official contact info\n" +
                   "- Report phishing to report@cybersecurity.gov.za\n" +
                   "- Delete the message immediately\n\n" +
                   "In South Africa, report phishing to the SAPS Cybercrime Unit!";
        }

        private string GetSafeBrowsingTips()
        {
            return "SAFE BROWSING HABITS\n\n" +
                   "Before clicking:\n" +
                   "- Check for 'https://' and the padlock in the address bar\n" +
                   "- Verify the website URL is spelled correctly (no typosquatting)\n" +
                   "- Be suspicious of pop-ups asking for personal info\n\n" +
                   "Best Practices:\n" +
                   "- Keep your browser and antivirus software UPDATED\n" +
                   "- Use ad-blockers and privacy extensions (uBlock Origin)\n" +
                   "- Clear your browsing history and cache regularly\n" +
                   "- Avoid saving passwords in your browser\n\n" +
                   "On Public Wi-Fi:\n" +
                   "- Never do banking or shopping on public Wi-Fi\n" +
                   "- Use a VPN (Virtual Private Network) when possible\n" +
                   "- Turn off file sharing and AirDrop\n\n" +
                   "Remember: If a deal looks too good to be true, it probably is!";
        }

        private string GetMalwareTips()
        {
            return "MALWARE PREVENTION GUIDE\n\n" +
                   "What is Malware?\n" +
                   "Malware includes viruses, ransomware, spyware, and trojans that can:\n" +
                   "- Steal your personal information\n" +
                   "- Lock your files (ransomware)\n" +
                   "- Use your computer to attack others\n\n" +
                   "PROTECTION TIPS:\n" +
                   "- Install reliable antivirus software (Windows Defender is good!)\n" +
                   "- NEVER download attachments from unknown senders\n" +
                   "- Only download software from official websites\n" +
                   "- Don't click on pop-up ads that say 'Your computer is infected'\n" +
                   "- Keep Windows and all software updated\n" +
                   "- Back up important files to an external drive or cloud\n\n" +
                   "IF INFECTED:\n" +
                   "- Disconnect from the internet immediately\n" +
                   "- Run a full antivirus scan\n" +
                   "- Change all your passwords from a clean device\n" +
                   "- For ransomware: DO NOT pay the ransom!";
        }

        private string GetSocialEngineeringTips()
        {
            return "SOCIAL ENGINEERING AWARENESS\n\n" +
                   "Social engineering is when scammers manipulate people into giving up information.\n\n" +
                   "COMMON TACTICS:\n" +
                   "- Pretending to be IT support or your bank\n" +
                   "- Creating fake urgency or fear\n" +
                   "- Impersonating a friend or family member\n" +
                   "- 'Vishing' - voice phishing over phone calls\n" +
                   "- 'Smishing' - phishing via SMS text messages\n\n" +
                   "HOW TO PROTECT YOURSELF:\n" +
                   "- Never give personal info to unsolicited callers\n" +
                   "- Hang up and call back using official numbers\n" +
                   "- Verify identities through another channel\n" +
                   "- Be skeptical of unexpected requests\n" +
                   "- Trust your gut - if it feels wrong, it probably is!\n\n" +
                   "South Africans: Banks will NEVER ask for your PIN or OTP!";
        }

        private string Get2FATips()
        {
            return "TWO-FACTOR AUTHENTICATION (2FA) GUIDE\n\n" +
                   "What is 2FA?\n" +
                   "2FA adds an extra layer of security beyond just your password.\n\n" +
                   "How it works:\n" +
                   "1. Enter your password\n" +
                   "2. Enter a code from your phone or authenticator app\n\n" +
                   "TYPES OF 2FA (best to worst):\n" +
                   "- Authenticator Apps (Google Authenticator, Microsoft Authenticator)\n" +
                   "- SMS Text Messages (better than nothing!)\n" +
                   "- Email Codes (least secure)\n\n" +
                   "PRO TIPS:\n" +
                   "- Enable 2FA on ALL accounts that offer it\n" +
                   "- Save backup codes in a safe place\n" +
                   "- Use an authenticator app instead of SMS when possible\n" +
                   "- Never share your 2FA codes with anyone\n\n" +
                   "South African banks use 2FA - always use it!";
        }

        private string GetDefaultResponse()
        {
            string[] responses = {
                "I'm not sure I understand. Could you rephrase that? \n\nTry asking me about:\n- Password safety\n- Phishing scams\n- Safe browsing\n- Malware protection",

                "Hmm, I didn't quite catch that. I specialize in cybersecurity topics! \n\nYou can ask me: 'How to spot phishing?' or 'Tell me about password safety'",

                "Great question! However, I focus on helping people stay safe online. \n\nWould you like to learn about passwords, phishing, or safe browsing?",

                "I'm still learning! Try asking me:\n- 'What is phishing?'\n- 'How to create strong passwords?'\n- 'Safe browsing tips?'",

                "Let me help you with cybersecurity! \n\nWhat would you like to know about:\n- Password protection\n- Email scams\n- Online safety"
            };
            Random rand = new Random();
            return responses[rand.Next(responses.Length)];
        }

        private void EmptyInputResponse()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("  NECH: I didn't hear anything.                         ");
            Console.WriteLine("     Please type a question or say 'help' for options.    ");
            Console.WriteLine("---------------------------------------------------------");
            Console.ResetColor();
        }

        private void DisplayResponse(string response)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nNECH: ");
            Console.ForegroundColor = ConsoleColor.White;

            // Typewriter effect for more engaging conversation
            foreach (char c in response)
            {
                Console.Write(c);
                Thread.Sleep(8); // Small delay for typing effect
            }
            Console.WriteLine("\n");
            Console.ResetColor();
        }

        private bool IsExitCommand(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string lowerInput = input.ToLower().Trim();
            return lowerInput == "quit" ||
                   lowerInput == "exit" ||
                   lowerInput == "goodbye" ||
                   lowerInput == "bye" ||
                   lowerInput == "end" ||
                   lowerInput == "stop";
        }

        private void SayGoodbye()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n==========================================================");
            Console.WriteLine("                                                          ");
            Console.WriteLine($"  GOODBYE, {userName}! Stay safe online!                           ");
            Console.WriteLine("                                                          ");
            Console.WriteLine("  REMEMBER:                                            ");
            Console.WriteLine("  - Think before you click                                ");
            Console.WriteLine("  - Never share your passwords                            ");
            Console.WriteLine("  - Verify suspicious emails                              ");
            Console.WriteLine("                                                          ");
            Console.WriteLine("  Together for a cyber-safe South Africa!              ");
            Console.WriteLine("                                                          ");
            Console.WriteLine("==========================================================");
            Console.ResetColor();
            Thread.Sleep(1500);
        }
    }
}