namespace CybersecurityAwarenessBot
{
    public class ChatBot
    {
        public string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
                return "I'm good, thank you! Hope you're staying safe online.";

            if (input.Contains("purpose"))
                return "I educate users on cybersecurity and safe online practices.";

            if (input.Contains("password"))
                return "Always use strong, unique passwords for each account.";

            if (input.Contains("phishing"))
                return "Never click on suspicious links or emails.";

            if (input.Contains("safe browsing"))
                return "Only browse secure websites (https).";

            return "I didn't quite understand that. Could you rephrase?";
        }
    }
}
