namespace ChatClient
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
            ConnectButton = new Button();
            SendButton = new Button();
            MessageTextBox = new TextBox();
            ChatTextBox = new TextBox();
            SuspendLayout();
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(90, 88);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(75, 23);
            ConnectButton.TabIndex = 0;
            ConnectButton.Text = "button1";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(90, 153);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(75, 23);
            SendButton.TabIndex = 1;
            SendButton.Text = "button1";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // MessageTextBox
            // 
            MessageTextBox.Location = new Point(220, 208);
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(333, 23);
            MessageTextBox.TabIndex = 2;
            // 
            // ChatTextBox
            // 
            ChatTextBox.Location = new Point(220, 46);
            ChatTextBox.Multiline = true;
            ChatTextBox.Name = "ChatTextBox";
            ChatTextBox.ReadOnly = true;
            ChatTextBox.ScrollBars = ScrollBars.Vertical;
            ChatTextBox.Size = new Size(333, 130);
            ChatTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChatTextBox);
            Controls.Add(MessageTextBox);
            Controls.Add(SendButton);
            Controls.Add(ConnectButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConnectButton;
        private Button SendButton;
        private TextBox MessageTextBox;
        private TextBox ChatTextBox;
    }
}
