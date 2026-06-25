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
            rtbChat.Location = new Point(52, 97);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbChat.Size = new Size(959, 462);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            // 
            // txtUserInput
            // 
            txtUserInput.Location = new Point(39, 589);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(758, 27);
            txtUserInput.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(844, 588);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(167, 29);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(411, 41);
            label1.TabIndex = 3;
            label1.Text = "Cybersecurity Awereness Bot";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1068, 662);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(txtUserInput);
            Controls.Add(rtbChat);
            Name = "Form1";
            Text = "Form1";
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
