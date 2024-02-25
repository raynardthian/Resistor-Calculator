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
    public partial class History : Form
    {
        public static History objHistory = new History();

        public History()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.objInterface.Show();
            objHistory = this;
            this.Hide();
            
        }

        private void colourButton_Click(object sender, EventArgs e)
        {
            
            string strColour;
            StreamReader streamColour = new StreamReader("Resistance Colour.txt");
            strColour = streamColour.ReadToEnd();                
            historyLabel.Text = strColour;           
            streamColour.Close();
            
        }

        private void resistanceButton_Click(object sender, EventArgs e)
        {
            string str3BandResistance;
            StreamReader stream3BandResistance = new StreamReader("3 Band Resistance.txt");
            str3BandResistance = stream3BandResistance.ReadToEnd();
            historyLabel.Text = str3BandResistance;
            stream3BandResistance.Close();
            
        }


        private void clearValueButton_Click(object sender, EventArgs e)
        {
            File.Delete("3 Band Resistance.txt");
            File.AppendAllText("3 Band Resistance.txt", "");
        }

        private void clearColourButton_Click(object sender, EventArgs e)
        {
            File.Delete("Resistance Colour.txt");
            File.AppendAllText("Resistance Colour.txt", "");
        }

        private void band4Button_Click(object sender, EventArgs e)
        {
            string str4BandResistance;
            StreamReader stream4BandResistance = new StreamReader("4 Band Resistance.txt");
            str4BandResistance = stream4BandResistance.ReadToEnd();
            historyLabel.Text = str4BandResistance;
            stream4BandResistance.Close();
        }

        private void clear4BandButton_Click(object sender, EventArgs e)
        {
            File.Delete("4 Band Resistance.txt");
            File.AppendAllText("4 Band Resistance.txt", "");
        }
    }
}
