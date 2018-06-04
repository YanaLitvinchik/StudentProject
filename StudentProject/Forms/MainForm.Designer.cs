namespace StudentProject
{
    partial class MainForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SMSbutton = new System.Windows.Forms.Button();
            this.TeacherLabel = new System.Windows.Forms.Label();
            this.TeacherComboBox = new System.Windows.Forms.ComboBox();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(205, 127);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(205, 174);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(205, 227);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // SMSbutton
            // 
            this.SMSbutton.Location = new System.Drawing.Point(205, 278);
            this.SMSbutton.Name = "SMSbutton";
            this.SMSbutton.Size = new System.Drawing.Size(75, 23);
            this.SMSbutton.TabIndex = 3;
            this.SMSbutton.Text = "SMS";
            this.SMSbutton.UseVisualStyleBackColor = true;
            this.SMSbutton.Click += new System.EventHandler(this.SMSbutton_Click);
            // 
            // TeacherLabel
            // 
            this.TeacherLabel.AutoSize = true;
            this.TeacherLabel.Location = new System.Drawing.Point(17, 29);
            this.TeacherLabel.Name = "TeacherLabel";
            this.TeacherLabel.Size = new System.Drawing.Size(53, 13);
            this.TeacherLabel.TabIndex = 4;
            this.TeacherLabel.Text = "Teacher :";
            // 
            // TeacherComboBox
            // 
            this.TeacherComboBox.FormattingEnabled = true;
            this.TeacherComboBox.Location = new System.Drawing.Point(20, 56);
            this.TeacherComboBox.Name = "TeacherComboBox";
            this.TeacherComboBox.Size = new System.Drawing.Size(121, 21);
            this.TeacherComboBox.TabIndex = 5;
            this.TeacherComboBox.SelectedIndexChanged += new System.EventHandler(this.TeacherComboBox_SelectedIndexChanged);
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Location = new System.Drawing.Point(17, 108);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(55, 13);
            this.StudentLabel.TabIndex = 6;
            this.StudentLabel.Text = "Students :";
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.Location = new System.Drawing.Point(20, 127);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(135, 173);
            this.StudentListBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 317);
            this.Controls.Add(this.StudentListBox);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.TeacherComboBox);
            this.Controls.Add(this.TeacherLabel);
            this.Controls.Add(this.SMSbutton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button SMSbutton;
        private System.Windows.Forms.Label TeacherLabel;
        private System.Windows.Forms.ComboBox TeacherComboBox;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.ListBox StudentListBox;
    }
}

