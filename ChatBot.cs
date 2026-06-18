using System;
using System.Collections.Generic;

namespace CybersecurityAwarenessBotGUI
{
    public class ChatBot
    {
        private Dictionary<string, string[]> responses;
        private string userName = "";
        private string favouriteTopic = "";

        Random random = new Random();

        public ChatBot()
        {
            responses = new Dictionary<string, string[]>()
{
{
"password",
new string[]
{
"Use strong passwords with symbols and numbers.",
"Never reuse passwords across websites.",
"Use a password manager for better security."
}
},

{
"phishing",
new string[]
{
"Never click suspicious email links.",
"Check the sender email carefully.",
"Scammers often pretend to be trusted companies."
}
},

{
"privacy",
new string[]
{
"Review your social media privacy settings.",
"Avoid sharing personal data publicly.",
"Enable two-factor authentication."
}
},

{
"scam",
new string[]
{
"Be cautious of offers that seem too good to be true.",
"Verify information before sending money.",
"Scammers often create urgency."
}
},

{
"malware",
new string[]
{
"Install antivirus software.",
"Avoid downloading files from unknown websites.",
"Keep your operating system updated."
}
},

{
"vpn",
new string[]
{
"A VPN helps protect your online privacy.",
"Use trusted VPN providers.",
"A VPN encrypts your internet traffic."
}
}
};
        }

        public string GetResponse(string input)
        {
            input = input.ToLower();

            // Memory Feature
            if (input.Contains("my name is"))
            {
                userName = input.Replace("my name is", "").Trim();
                return $"Nice to meet you, {userName}.";
            }

            if (input.Contains("i like"))
            {
                favouriteTopic = input.Replace("i like", "").Trim();
                return $"Great! I will remember that you like {favouriteTopic}.";
            }

            // Sentiment Detection
            if (input.Contains("worried") || input.Contains("scared"))
            {
                return "It is understandable to feel worried. Cybersecurity can be challenging, but I will help you stay safe.";
            }
            
            if (input.Contains("frustrated"))
            {
                return "I understand cybersecurity can be frustrating. Take things step by step and stay patient.";
            }

            if (input.Contains("curious"))
            {
                return "Curiosity is great for learning cybersecurity. What topic would you like to explore?";
            }
            
            // Keyword Recognition
            foreach (var keyword in responses.Keys)
            {
                if (input.Contains(keyword))
                {
                    string[] possibleResponses = responses[keyword];
                    return possibleResponses[random.Next(possibleResponses.Length)];
                }
            }

            // Conversation Flow
            if (input.Contains("another tip"))
            {
                return "Always keep your software updated to protect against vulnerabilities.";
            }

            if (input.Contains("tell me more"))
            {
                return "Cybercriminals often rely on human mistakes. Staying informed is your first line of defence.";
            }

            if (input.Contains("explain more"))
            {
                return "Strong passwords, privacy settings, and phishing awareness are essential cybersecurity practices.";
            }

            if (input.Contains("more"))
            {
                return "Always stay alert online and never share sensitive information carelessly.";
            }

            // Recall Memory
            if (input.Contains("what do i like"))
            {
                return $"You told me you like {favouriteTopic}.";
            }
            
            if (input.Contains("what is my name"))
            {
                return $"Your name is {userName}.";
            }

            // Default Response
            return "I am not sure I understand. Can you rephrase?";
        }
    }
}