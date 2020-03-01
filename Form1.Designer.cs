namespace TextReplacementTool
{
    partial class Form1
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
            this.TextInputBox = new System.Windows.Forms.RichTextBox();
            this.TextOutputBox = new System.Windows.Forms.RichTextBox();
            this.searchBox_1 = new System.Windows.Forms.TextBox();
            this.replacementBox_1 = new System.Windows.Forms.TextBox();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // TextInputBox
            // 
            this.TextInputBox.AcceptsTab = true;
            this.TextInputBox.AutoWordSelection = true;
            this.TextInputBox.Location = new System.Drawing.Point(22, 12);
            this.TextInputBox.Name = "TextInputBox";
            this.TextInputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextInputBox.Size = new System.Drawing.Size(135, 299);
            this.TextInputBox.TabIndex = 2;
            this.TextInputBox.Text = "";
            this.TextInputBox.TextChanged += new System.EventHandler(this.TextInputBox_TextChanged);
            // 
            // TextOutputBox
            // 
            this.TextOutputBox.Location = new System.Drawing.Point(375, 13);
            this.TextOutputBox.Name = "TextOutputBox";
            this.TextOutputBox.ReadOnly = true;
            this.TextOutputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextOutputBox.Size = new System.Drawing.Size(135, 298);
            this.TextOutputBox.TabIndex = 3;
            this.TextOutputBox.Text = "";
            this.TextOutputBox.TextChanged += new System.EventHandler(this.TextOutputBox_TextChanged);
            // 
            // searchBox_1
            // 
            this.searchBox_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchBox_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox_1.Location = new System.Drawing.Point(220, 85);
            this.searchBox_1.Name = "searchBox_1";
            this.searchBox_1.Size = new System.Drawing.Size(100, 20);
            this.searchBox_1.TabIndex = 4;
            // 
            // replacementBox_1
            // 
            this.replacementBox_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.replacementBox_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.replacementBox_1.Location = new System.Drawing.Point(220, 147);
            this.replacementBox_1.Name = "replacementBox_1";
            this.replacementBox_1.Size = new System.Drawing.Size(100, 20);
            this.replacementBox_1.TabIndex = 4;
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(220, 288);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(75, 23);
            this.ReplaceButton.TabIndex = 5;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // f
            // 
            this.f.Location = new System.Drawing.Point(211, 69);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(109, 37);
            this.f.TabIndex = 6;
            this.f.TabStop = false;
            this.f.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(211, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 37);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replace";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 327);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.replacementBox_1);
            this.Controls.Add(this.searchBox_1);
            this.Controls.Add(this.TextOutputBox);
            this.Controls.Add(this.TextInputBox);
            this.Controls.Add(this.f);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TextReplacementTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextInputBox;
        private System.Windows.Forms.RichTextBox TextOutputBox;
        private System.Windows.Forms.TextBox searchBox_1;
        private System.Windows.Forms.TextBox replacementBox_1;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.GroupBox f;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

