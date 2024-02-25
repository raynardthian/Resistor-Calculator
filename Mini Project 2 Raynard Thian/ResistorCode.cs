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
    public partial class ResistorCode : Form
    {
        public static ResistorCode objResistor = new ResistorCode();
        public ResistorCode()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (band2ComboBox.Text == "Black")       // To Change colours 
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

        private void valueButton_Click(object sender, EventArgs e)
        {
            double c = 0.0f,resistance =0.0f;
            int d = 0, a = 0, b = 0;
            
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
                if (band2ComboBox.Text == "Black") // Finding the 2nd Band Colour
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
                if (band3ComboBox.Text == "Black") // Finding the 3rd Band Colour
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
                    c = 10* 10 * 10 * 10;
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
                d = a * 10;
                resistance = (d+b)*c ;
                resistanceTextBox.Text = resistance.ToString();               
                StreamWriter ResistanceFile = new StreamWriter("3 Band Resistance.txt", true);
                ResistanceFile.WriteLine(resistance);
                ResistanceFile.Close();

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

        private void quitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a nice day!", "Resistor Calculator");
            Application.Exit();
        }

        private void colourButton_Click(object sender, EventArgs e)
        {
            double resistance = 0.0f,divider = 0.0f, LeftOverForBand3 = 0.0f,band1=0.0f,band2=0.0f ;
            resistance = double.Parse(resistanceTextBox.Text);
            string band1colour="", band2colour="", band3colour="";
            if (resistanceTextBox.Text == "")
            {
                MessageBox.Show("Please Enter a Resistance Value", "Resistance Value");
            }
            else
            {
                if (resistance < 99999999999 && resistance > 9999999999)// To find band 3 Colour
                {
                    band3ComboBox.Text = "White"; // 10 to the power of 9
                    divider = 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10;
                    band3colour = "+ White";
                }
                else if (resistance < 9999999999 && resistance > 999999999)
                {
                    band3ComboBox.Text = "Gray"; // 10 to the power of 8
                    divider = 10 * 10 * 10 * 10 * 10 * 10 * 10 * 10;
                    band3colour = "+ Gray";
                }
                else if (resistance < 999999999 && resistance > 99999999)
                {
                    band3ComboBox.Text = "Violet"; // 10 to the power of 7
                    divider = 10 * 10 * 10 * 10 * 10 * 10 * 10;
                    band3colour = "+ Violet";
                }
                else if (resistance < 99999999 && resistance > 9999999)
                {
                    band3ComboBox.Text = "Blue"; // 10 to the power of 6
                    divider = 10 * 10 * 10 * 10 * 10 * 10;
                    band3colour = "+ Blue";
                }
                else if (resistance < 9999999 && resistance > 999999)
                {
                    band3ComboBox.Text = "Green"; // 10 to the power of 5
                    divider = 10 * 10 * 10 * 10 * 10;
                    band3colour = "+ Green";
                }
                else if (resistance < 999999 && resistance > 99999)
                {
                    band3ComboBox.Text = "Yellow"; // 10 to the power of 4
                    divider = 10 * 10 * 10 * 10;
                    band3colour = "+ Yellow";
                }
                else if (resistance < 99999 && resistance > 9999)
                {
                    band3ComboBox.Text = "Orange"; // 10 to the power of 3
                    divider = 10 * 10 * 10;
                    band3colour = "+ Orange";
                }
                else if (resistance < 9999 && resistance > 999)
                {
                    band3ComboBox.Text = "Red"; // 10 to the power 2
                    divider = 10 * 10;
                    band3colour = "+ Red";
                }
                else if (resistance < 999 && resistance > 99)
                {
                    band3ComboBox.Text = "Brown"; // 10 to the power of 1
                    divider = 10;
                    band3colour = "+ Brown";
                }
                else
                {
                    band3ComboBox.Text = "Black"; // 10 to the power of 0
                    divider = 1;
                    band3colour = "+ Black";
                }
                LeftOverForBand3 = resistance / divider;
                band2 = LeftOverForBand3 % 10;
                band1 = LeftOverForBand3 / 10;

                if (band2 < 9.99999999999999 && band2 >= 9) // To find Band 2 Colour
                {
                    band2ComboBox.Text = "White";
                    band2colour = "+ White ";
                }
                else if (band2 < 8.99999999999999 && band2 >= 8)
                {
                    band2ComboBox.Text = "Gray";
                    band2colour = "+ Gray ";
                }
                else if (band2 < 7.99999999999999 && band2 >= 7)
                {
                    band2ComboBox.Text = "Violet";
                    band2colour = "+ Violet ";
                }
                else if (band2 < 6.99999999999999 && band2 >= 6)
                {
                    band2ComboBox.Text = "Blue";
                    band2colour = "+ Blue ";
                }
                else if (band2 < 5.99999999999999 && band2 >= 5)
                {
                    band2ComboBox.Text = "Green";
                    band2colour = "+ Green ";
                }
                else if (band2 < 4.99999999999999 && band2 >= 4)
                {
                    band2ComboBox.Text = "Yellow";
                    band2colour = "+ Yellow ";
                }
                else if (band2 < 3.99999999999999 && band2 >= 3)
                {
                    band2ComboBox.Text = "Orange";
                    band2colour = "+ Orange ";
                }
                else if (band2 < 2.99999999999999 && band2 >= 2)
                {
                    band2ComboBox.Text = "Red";
                    band2colour = "+ Red ";
                }
                else if (band2 < 1.99999999999999 && band2 >= 1)
                {
                    band2ComboBox.Text = "Brown";
                    band2colour = "+ Brown ";
                }
                else
                {
                    band2ComboBox.Text = "Black";
                    band2colour = "+ Black ";
                }
                if (band1 < 9.99999999999999 && band1 >= 9) // To find Band 1 Colour
                {
                    band1ComboBox.Text = "White";
                    band1colour = "White ";
                }
                else if (band1 < 8.99999999999999 && band1 >= 8)
                {
                    band1ComboBox.Text = "Gray";
                    band1colour = "Gray ";
                }
                else if (band1 < 7.99999999999999 && band1 >= 7)
                {
                    band1ComboBox.Text = "Violet";
                    band1colour = "Violet ";
                }
                else if (band1 < 6.99999999999999 && band1 >= 6)
                {
                    band1ComboBox.Text = "Blue";
                    band1colour = "Blue ";
                }
                else if (band1 < 5.99999999999999 && band1 >= 5)
                {
                    band1ComboBox.Text = "Green";
                    band1colour = "Green ";
                }
                else if (band1 < 4.99999999999999 && band1 >= 4)
                {
                    band1ComboBox.Text = "Yellow";
                    band1colour = "Yellow ";
                }
                else if (band1 < 3.99999999999999 && band1 >= 3)
                {
                    band1ComboBox.Text = "Orange";
                    band1colour = "Orange ";
                }
                else if (band1 < 2.99999999999999 && band1 >= 2)
                {
                    band1ComboBox.Text = "Red";
                    band1colour = "Red ";
                }
                else if (band1 < 1.99999999999999 && band1 >= 1)
                {
                    band1ComboBox.Text = "Brown";
                    band1colour = "Brown ";
                }
                else
                {
                    band1ComboBox.Text = "Black";
                    band1colour = "Black ";
                }
                
                StreamWriter ResistanceColour = new StreamWriter("Resistance Colour.txt",true);
                ResistanceColour.WriteLine(band1colour + band2colour + band3colour) ;
                ResistanceColour.Close();
                
            }
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            History.objHistory.Show();
            objResistor = this;
            this.Hide();
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

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.objInterface.Show();
            objResistor = this;
            this.Hide();
        }
    }
}
