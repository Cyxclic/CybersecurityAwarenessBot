using System;
using System.Windows.Forms;

namespace CybersecurityAwarenessBotGUI
{
    public partial class Form1 : Form
    {
        ChatBot bot = new ChatBot();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text;

            rtbChat.AppendText("You: " + userInput + Environment.NewLine);

            string response = bot.GetResponse(userInput);

            rtbChat.AppendText("Bot: " + response + Environment.NewLine + Environment.NewLine);

            txtUserInput.Clear();
        }
    }
}