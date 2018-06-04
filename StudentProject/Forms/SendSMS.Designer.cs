namespace StudentProject
{
    partial class SendSMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberLabel = new System.Windows.Forms.Label();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.TextSMSlistBox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Symbolslabel = new System.Windows.Forms.Label();
            this.CountOfSmsLabel = new System.Windows.Forms.Label();
            this.OwnertextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(30, 47);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(44, 13);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "Number";
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Location = new System.Drawing.Point(33, 110);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(38, 13);
            this.OwnerLabel.TabIndex = 1;
            this.OwnerLabel.Text = "Owner";
            // 
            // TextSMSlistBox
            // 
            this.TextSMSlistBox.FormattingEnabled = true;
            this.TextSMSlistBox.Location = new System.Drawing.Point(33, 165);
            this.TextSMSlistBox.Name = "TextSMSlistBox";
            this.TextSMSlistBox.Size = new System.Drawing.Size(279, 95);
            this.TextSMSlistBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(36, 301);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(237, 301);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // Symbolslabel
            // 
            this.Symbolslabel.AutoSize = true;
            this.Symbolslabel.Location = new System.Drawing.Point(36, 267);
            this.Symbolslabel.Name = "Symbolslabel";
            this.Symbolslabel.Size = new System.Drawing.Size(67, 13);
            this.Symbolslabel.TabIndex = 6;
            this.Symbolslabel.Text = "Symbols : 82";
            // 
            // CountOfSmsLabel
            // 
            this.CountOfSmsLabel.AutoSize = true;
            this.CountOfSmsLabel.Location = new System.Drawing.Point(237, 266);
            this.CountOfSmsLabel.Name = "CountOfSmsLabel";
            this.CountOfSmsLabel.Size = new System.Drawing.Size(37, 13);
            this.CountOfSmsLabel.TabIndex = 7;
            this.CountOfSmsLabel.Text = "sms: 2";
            // 
            // OwnertextBox1
            // 
            this.OwnertextBox1.Location = new System.Drawing.Point(112, 107);
            this.OwnertextBox1.Name = "OwnertextBox1";
            this.OwnertextBox1.Size = new System.Drawing.Size(121, 20);
            this.OwnertextBox1.TabIndex = 8;
            this.OwnertextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 352);
            this.Controls.Add(this.OwnertextBox1);
            this.Controls.Add(this.CountOfSmsLabel);
            this.Controls.Add(this.Symbolslabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TextSMSlistBox);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.NumberLabel);
            this.Name = "SendSMS";
            this.Text = "SendSMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.ListBox TextSMSlistBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label Symbolslabel;
        private System.Windows.Forms.Label CountOfSmsLabel;
        private System.Windows.Forms.TextBox OwnertextBox1;
    }
}