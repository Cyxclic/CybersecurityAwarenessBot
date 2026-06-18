namespace CybersecurityAwarenessBotGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbChat = new RichTextBox();
            txtUserInput = new TextBox();
            btnSend = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // rtbChat
            // 
            rtbChat.BackColor = SystemColors.Window;
            rtbChat.Location = new Point(27, 60);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbChat.Size = new Size(747, 288);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            // 
            // txtUserInput
            // 
            txtUserInput.Location = new Point(37, 382);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(584, 27);
            txtUserInput.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(627, 381);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 9);
            label1.Name = "label1";
            label1.Size = new Size(395, 38);
            label1.TabIndex = 3;
            label1.Text = "Cybersecurity Awareness Bot";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(txtUserInput);
            Controls.Add(rtbChat);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cybersecurity Awareness Bot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbChat;
        private TextBox txtUserInput;
        private Button btnSend;
        private Label label1;
    }
}
