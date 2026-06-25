using System;
using System.Collections.Generic;

namespace CybersecurityAwarenessBotGUI
{
    public class ChatBot
    {
        private Dictionary<string, string[]> responses;
        private Random random = new Random();

        private string userName = "";
        private string favouriteTopic = "";

        public ChatBot()
        {
            responses = new Dictionary<string, string[]>()
            {
                {
                    "password",
                    new string[]
                    {
                        "Use strong passwords with numbers and symbols.",
                        "Never reuse passwords on multiple sites.",
                        "Use a password manager."
                    }
                },
                {
                    "phishing",
                    new string[]
                    {
                        "Never click suspicious links.",
                        "Check email addresses carefully."
                    }
                },
                {
                    "privacy",
                    new string[]
                    {
                        "Adjust your social media privacy settings.",
                        "Do not share personal info online."
                    }
                }
            };
        }

        public string GetResponse(string input)
        {
            input = input.ToLower();

            // MEMORY FEATURE (PART 3)
            if (input.Contains("my name is"))
            {
                userName = input.Replace("my name is", "").Trim();
                return "Nice to meet you " + userName;
            }

            if (input.Contains("i like"))
            {
                favouriteTopic = input.Replace("i like", "").Trim();
                return "I will remember that you like " + favouriteTopic;
            }

            if (input.Contains("what is my name"))
                return "Your name is " + userName;

            if (input.Contains("what do i like"))
                return "You like " + favouriteTopic;

            // BOT RESPONSES
            foreach (var key in responses.Keys)
            {
                if (input.Contains(key))
                {
                    var list = responses[key];
                    return list[random.Next(list.Length)];
                }
            }

            return "Ask me about passwords, phishing, or privacy.";
        }
    }
}