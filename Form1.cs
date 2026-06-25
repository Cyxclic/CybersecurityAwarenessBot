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

            // Connect Send button to click event
            btnSend.Click += btnSend_Click;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = txtUserInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            rtbChat.AppendText("You: " + input + Environment.NewLine);

            string response = bot.GetResponse(input);

            rtbChat.AppendText("Bot: " + response + Environment.NewLine + Environment.NewLine);

            txtUserInput.Clear();
        }
    }
}