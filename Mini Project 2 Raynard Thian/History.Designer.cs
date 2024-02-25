namespace Mini_Project_2_Raynard_Thian
{
    partial class History
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
            this.historyLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.colourButton = new System.Windows.Forms.Button();
            this.resistanceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clearColourButton = new System.Windows.Forms.Button();
            this.clearValueButton = new System.Windows.Forms.Button();
            this.band4Button = new System.Windows.Forms.Button();
            this.clear4BandButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // historyLabel
            // 
            this.historyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.historyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLabel.Location = new System.Drawing.Point(23, 40);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(385, 482);
            this.historyLabel.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(536, 397);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 77);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back To Interface";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // colourButton
            // 
            this.colourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourButton.Location = new System.Drawing.Point(441, 104);
            this.colourButton.Name = "colourButton";
            this.colourButton.Size = new System.Drawing.Size(132, 77);
            this.colourButton.TabIndex = 3;
            this.colourButton.Text = "Resistor Colour";
            this.colourButton.UseVisualStyleBackColor = false;
            this.colourButton.Click += new System.EventHandler(this.colourButton_Click);
            // 
            // resistanceButton
            // 
            this.resistanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.resistanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resistanceButton.Location = new System.Drawing.Point(441, 187);
            this.resistanceButton.Name = "resistanceButton";
            this.resistanceButton.Size = new System.Drawing.Size(134, 77);
            this.resistanceButton.TabIndex = 4;
            this.resistanceButton.Text = "3 Band Past Resistance Value";
            this.resistanceButton.UseVisualStyleBackColor = false;
            this.resistanceButton.Click += new System.EventHandler(this.resistanceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Past Searches using Resistor Calculator";
            // 
            // clearColourButton
            // 
            this.clearColourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clearColourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearColourButton.Location = new System.Drawing.Point(598, 104);
            this.clearColourButton.Name = "clearColourButton";
            this.clearColourButton.Size = new System.Drawing.Size(121, 77);
            this.clearColourButton.TabIndex = 6;
            this.clearColourButton.Text = "Clear Colour History";
            this.clearColourButton.UseVisualStyleBackColor = false;
            this.clearColourButton.Click += new System.EventHandler(this.clearColourButton_Click);
            // 
            // clearValueButton
            // 
            this.clearValueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.clearValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearValueButton.Location = new System.Drawing.Point(598, 187);
            this.clearValueButton.Name = "clearValueButton";
            this.clearValueButton.Size = new System.Drawing.Size(121, 77);
            this.clearValueButton.TabIndex = 7;
            this.clearValueButton.Text = "Clear 3 Band Value History";
            this.clearValueButton.UseVisualStyleBackColor = false;
            this.clearValueButton.Click += new System.EventHandler(this.clearValueButton_Click);
            // 
            // band4Button
            // 
            this.band4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.band4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band4Button.Location = new System.Drawing.Point(441, 270);
            this.band4Button.Name = "band4Button";
            this.band4Button.Size = new System.Drawing.Size(132, 77);
            this.band4Button.TabIndex = 8;
            this.band4Button.Text = "4 Band Past Resistance Value";
            this.band4Button.UseVisualStyleBackColor = false;
            this.band4Button.Click += new System.EventHandler(this.band4Button_Click);
            // 
            // clear4BandButton
            // 
            this.clear4BandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clear4BandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear4BandButton.Location = new System.Drawing.Point(598, 272);
            this.clear4BandButton.Name = "clear4BandButton";
            this.clear4BandButton.Size = new System.Drawing.Size(121, 77);
            this.clear4BandButton.TabIndex = 9;
            this.clear4BandButton.Text = "Clear 4 Band Value History";
            this.clear4BandButton.UseVisualStyleBackColor = false;
            this.clear4BandButton.Click += new System.EventHandler(this.clear4BandButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "Checking of \r\nPast Searches\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clearing of \r\nHistory";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clear4BandButton);
            this.Controls.Add(this.band4Button);
            this.Controls.Add(this.clearValueButton);
            this.Controls.Add(this.clearColourButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resistanceButton);
            this.Controls.Add(this.colourButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.historyLabel);
            this.Name = "History";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button colourButton;
        private System.Windows.Forms.Button resistanceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearColourButton;
        private System.Windows.Forms.Button clearValueButton;
        private System.Windows.Forms.Button band4Button;
        private System.Windows.Forms.Button clear4BandButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}