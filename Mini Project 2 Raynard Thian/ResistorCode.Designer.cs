namespace Mini_Project_2_Raynard_Thian
{
    partial class ResistorCode
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
            this.band1ComboBox = new System.Windows.Forms.ComboBox();
            this.band2ComboBox = new System.Windows.Forms.ComboBox();
            this.band3ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resistanceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.valueButton = new System.Windows.Forms.Button();
            this.colourButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.band1Label = new System.Windows.Forms.Label();
            this.band2Label = new System.Windows.Forms.Label();
            this.band3Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // band1ComboBox
            // 
            this.band1ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band1ComboBox.FormattingEnabled = true;
            this.band1ComboBox.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.band1ComboBox.Location = new System.Drawing.Point(26, 90);
            this.band1ComboBox.Name = "band1ComboBox";
            this.band1ComboBox.Size = new System.Drawing.Size(121, 28);
            this.band1ComboBox.TabIndex = 0;
            this.band1ComboBox.SelectedIndexChanged += new System.EventHandler(this.band1ComboBox_SelectedIndexChanged);
            // 
            // band2ComboBox
            // 
            this.band2ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band2ComboBox.FormattingEnabled = true;
            this.band2ComboBox.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.band2ComboBox.Location = new System.Drawing.Point(181, 90);
            this.band2ComboBox.Name = "band2ComboBox";
            this.band2ComboBox.Size = new System.Drawing.Size(121, 28);
            this.band2ComboBox.TabIndex = 1;
            this.band2ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // band3ComboBox
            // 
            this.band3ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band3ComboBox.FormattingEnabled = true;
            this.band3ComboBox.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.band3ComboBox.Location = new System.Drawing.Point(338, 90);
            this.band3ComboBox.Name = "band3ComboBox";
            this.band3ComboBox.Size = new System.Drawing.Size(121, 28);
            this.band3ComboBox.TabIndex = 2;
            this.band3ComboBox.SelectedIndexChanged += new System.EventHandler(this.band3ComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Band 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Band 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Band 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resistance =";
            // 
            // resistanceTextBox
            // 
            this.resistanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resistanceTextBox.Location = new System.Drawing.Point(303, 179);
            this.resistanceTextBox.Name = "resistanceTextBox";
            this.resistanceTextBox.Size = new System.Drawing.Size(158, 26);
            this.resistanceTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ohms";
            // 
            // valueButton
            // 
            this.valueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueButton.Location = new System.Drawing.Point(250, 299);
            this.valueButton.Name = "valueButton";
            this.valueButton.Size = new System.Drawing.Size(91, 76);
            this.valueButton.TabIndex = 9;
            this.valueButton.Text = "Convert To Value";
            this.valueButton.UseVisualStyleBackColor = true;
            this.valueButton.Click += new System.EventHandler(this.valueButton_Click);
            // 
            // colourButton
            // 
            this.colourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourButton.Location = new System.Drawing.Point(394, 299);
            this.colourButton.Name = "colourButton";
            this.colourButton.Size = new System.Drawing.Size(91, 76);
            this.colourButton.TabIndex = 10;
            this.colourButton.Text = "Convert To Colour";
            this.colourButton.UseVisualStyleBackColor = true;
            this.colourButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.Location = new System.Drawing.Point(100, 299);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(91, 76);
            this.historyButton.TabIndex = 11;
            this.historyButton.Text = "Recent History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(569, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 97);
            this.label6.TabIndex = 12;
            // 
            // band1Label
            // 
            this.band1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.band1Label.Location = new System.Drawing.Point(599, 79);
            this.band1Label.Name = "band1Label";
            this.band1Label.Size = new System.Drawing.Size(25, 97);
            this.band1Label.TabIndex = 13;
            // 
            // band2Label
            // 
            this.band2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.band2Label.Location = new System.Drawing.Point(647, 79);
            this.band2Label.Name = "band2Label";
            this.band2Label.Size = new System.Drawing.Size(25, 97);
            this.band2Label.TabIndex = 14;
            // 
            // band3Label
            // 
            this.band3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.band3Label.Location = new System.Drawing.Point(697, 79);
            this.band3Label.Name = "band3Label";
            this.band3Label.Size = new System.Drawing.Size(25, 97);
            this.band3Label.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(515, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(783, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 17;
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(770, 299);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(91, 76);
            this.quitButton.TabIndex = 18;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(599, 299);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 88);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back To Interface";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(202, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(422, 39);
            this.label12.TabIndex = 48;
            this.label12.Text = "3 Band Resistor Calculator";
            // 
            // ResistorCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.band3ComboBox);
            this.Controls.Add(this.band3Label);
            this.Controls.Add(this.band2Label);
            this.Controls.Add(this.band1Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.colourButton);
            this.Controls.Add(this.valueButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resistanceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.band2ComboBox);
            this.Controls.Add(this.band1ComboBox);
            this.Name = "ResistorCode";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox band1ComboBox;
        private System.Windows.Forms.ComboBox band2ComboBox;
        private System.Windows.Forms.ComboBox band3ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resistanceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button valueButton;
        private System.Windows.Forms.Button colourButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label band1Label;
        private System.Windows.Forms.Label band2Label;
        private System.Windows.Forms.Label band3Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label12;
    }
}

