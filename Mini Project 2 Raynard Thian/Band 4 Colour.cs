using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mini_Project_2_Raynard_Thian
{
    public partial class Form2 : Form
    {
        public static Form2 objBand4 = new Form2();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void band1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (band1ComboBox.Text == "Black")// To Change colours 
            {
                band1Label.BackColor = Color.Black;
            }
            else if (band1ComboBox.Text == "Brown")
            {
                band1Label.BackColor = Color.Brown;
            }
            else if (band1ComboBox.Text == "Red")
            {
                band1Label.BackColor = Color.Red;
            }
            else if (band1ComboBox.Text == "Orange")
            {
                band1Label.BackColor = Color.Orange;
            }
            else if (band1ComboBox.Text == "Yellow")
            {
                band1Label.BackColor = Color.Yellow;
            }
            else if (band1ComboBox.Text == "Green")
            {
                band1Label.BackColor = Color.Green;
            }
            else if (band1ComboBox.Text == "Blue")
            {
                band1Label.BackColor = Color.Blue;
            }
            else if (band1ComboBox.Text == "Violet")
            {
                band1Label.BackColor = Color.Violet;
            }
            else if (band1ComboBox.Text == "Gray")
            {
                band1Label.BackColor = Color.Gray;
            }
            else
            {
                band1Label.BackColor = Color.White;
            }
        }

        private void band2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (band2ComboBox.Text == "Black")   // To Change colours 
            {
                band2Label.BackColor = Color.Black;
            }
            else if (band2ComboBox.Text == "Brown")
            {
                band2Label.BackColor = Color.Brown;
            }
            else if (band2ComboBox.Text == "Red")
            {
                band2Label.BackColor = Color.Red;
            }
            else if (band2ComboBox.Text == "Orange")
            {
                band2Label.BackColor = Color.Orange;
            }
            else if (band2ComboBox.Text == "Yellow")
            {
                band2Label.BackColor = Color.Yellow;
            }
            else if (band2ComboBox.Text == "Green")
            {
                band2Label.BackColor = Color.Green;
            }
            else if (band2ComboBox.Text == "Blue")
            {
                band2Label.BackColor = Color.Blue;
            }
            else if (band2ComboBox.Text == "Violet")
            {
                band2Label.BackColor = Color.Violet;
            }
            else if (band2ComboBox.Text == "Gray")
            {
                band2Label.BackColor = Color.Gray;
            }
            else
            {
                band2Label.BackColor = Color.White;
            }
        }

        private void band3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (band3ComboBox.Text == "Black")   // To Change colours 
            {
                band3Label.BackColor = Color.Black;
            }
            else if (band3ComboBox.Text == "Brown")
            {
                band3Label.BackColor = Color.Brown;
            }
            else if (band3ComboBox.Text == "Red")
            {
                band3Label.BackColor = Color.Red;
            }
            else if (band3ComboBox.Text == "Orange")
            {
                band3Label.BackColor = Color.Orange;
            }
            else if (band3ComboBox.Text == "Yellow")
            {
                band3Label.BackColor = Color.Yellow;
            }
            else if (band3ComboBox.Text == "Green")
            {
                band3Label.BackColor = Color.Green;
            }
            else if (band3ComboBox.Text == "Blue")
            {
                band3Label.BackColor = Color.Blue;
            }
            else if (band3ComboBox.Text == "Violet")
            {
                band3Label.BackColor = Color.Violet;
            }
            else if (band3ComboBox.Text == "Gray")
            {
                band3Label.BackColor = Color.Gray;
            }
            else
            {
                band3Label.BackColor = Color.White;
            }
        }

        private void band4ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (band4ComboBox.Text == "Silver")
            {
                band4Label.BackColor = Color.Silver;
            }
            else if (band4ComboBox.Text == "Gold")
            {
                band4Label.BackColor = Color.Gold;
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a nice day!", "Resistor Calculator");
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.objInterface.Show();
            objBand4 = this;
            this.Hide();

        }

        private void valueButton_Click(object sender, EventArgs e)
        {
            double c = 0.0f, resistance = 0.0f, tolerance = 0.0f, totalValueOfTolerance = 0.0f;
            int d = 0, a = 0, b = 0, minimumResistance = 0, maximumResistance = 0;

            if (band1ComboBox.Text == "")
            {
                MessageBox.Show("Please input Band 1 Colour", "Value of Band 1");
                band1ComboBox.Focus();
            }
            else if (band2ComboBox.Text == "")
            {
                MessageBox.Show("Please input Band 2 Colour", "Value of Band 2");
                band2ComboBox.Focus();
            }
            else if (band3ComboBox.Text == "")
            {
                MessageBox.Show("Please input Band 3 Colour", "Value of Band 3");
                band3ComboBox.Focus();
            }
            else if (band4ComboBox.Text == "")
            {
                MessageBox.Show("Please input Band 4 Colour", "Value of Band 4");
                band4ComboBox.Focus();
            }
            else
            {
                if (band1ComboBox.Text == "Black") // Finding the 1st Band Colour
                {
                    a = 0;
                }
                else if (band1ComboBox.Text == "Brown")
                {
                    a = 1;
                }
                else if (band1ComboBox.Text == "Red")
                {
                    a = 2;
                }
                else if (band1ComboBox.Text == "Orange")
                {
                    a = 3;
                }
                else if (band1ComboBox.Text == "Yellow")
                {
                    a = 4;
                }
                else if (band1ComboBox.Text == "Green")
                {
                    a = 5;
                }
                else if (band1ComboBox.Text == "Blue")
                {
                    a = 6;
                }
                else if (band1ComboBox.Text == "Violet")
                {
                    a = 7;
                }
                else if (band1ComboBox.Text == "Gray")
                {
                    a = 8;
                }
                else
                {
                    a = 9;
                }
                if (band2ComboBox.Text == "Black")  // Finding the 2nd Band Value
                {
                    b = 0;
                }
                else if (band2ComboBox.Text == "Brown")
                {
                    b = 1;
                }
                else if (band2ComboBox.Text == "Red")
                {
                    b = 2;
                }
                else if (band2ComboBox.Text == "Orange")
                {
                    b = 3;
                }
                else if (band2ComboBox.Text == "Yellow")
                {
                    b = 4;
                }
                else if (band2ComboBox.Text == "Green")
                {
                    b = 5;
                }
                else if (band2ComboBox.Text == "Blue")
                {
                    b = 6;
                }
                else if (band2ComboBox.Text == "Violet")
                {
                    b = 7;
                }
                else if (band2ComboBox.Text == "Gray")
                {
                    b = 8;
                }
                else
                {
                    b = 9;
                }
                if (band3ComboBox.Text == "Black")  // Finding the 3rd Band Multiplier
                {
                    c = 1;
                }
                else if (band3ComboBox.Text == "Brown")
                {
                    c = 10;
                }
                else if (band3ComboBox.Text == "Red")
                {
                    c = 10 * 10;
                }
                else if (band3ComboBox.Text == "Orange")
                {
                    c = 10 * 10 * 10;
                }
                else if (band3ComboBox.Text == "Yellow")
                {
                    c = 10 * 10 * 10 * 10;
                }
                else if (band3ComboBox.Text == "Green")
                {
                    c = 10 * 10 * 10 * 10 * 10;
                }
                else if (band3ComboBox.Text == "Blue")
                {
                    c = 10 * 10 * 10 * 10 * 10 * 10;
                }
                else if (band3ComboBox.Text == "Violet")
                {
                    c = 10 * 10 * 10 * 10 * 10 * 10 * 10;
                }
                else if (band3ComboBox.Text == "Gray")
                {
                    c = 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10;
                }
                else
                {
                    c = 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10;
                }
                if (band4ComboBox.Text == "Gold") // To Find the Tolerance of Resistor
                {
                    tolerance = 0.05f;
                }
                else if (band4ComboBox.Text == "Silver")
                {
                    tolerance = 0.1f;
                }
                d = a * 10;
                resistance = (d + b) * c;
                totalValueOfTolerance = resistance * tolerance;
                minimumResistance = (int)resistance - (int)totalValueOfTolerance;
                maximumResistance = (int)resistance + (int)totalValueOfTolerance;

                minimumLabel.Text = minimumResistance.ToString();
                maximumLabel.Text = maximumResistance.ToString();
                StreamWriter BandResistanceFile = new StreamWriter("4 Band Resistance.txt", true);
                BandResistanceFile.WriteLine("Maximum Value : " + maximumResistance);
                BandResistanceFile.WriteLine("Minimum Value : " + minimumResistance);
                BandResistanceFile.Close();
            }
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            History.objHistory.Show();
            objBand4 = this;
            this.Hide();
        }
    }
}
