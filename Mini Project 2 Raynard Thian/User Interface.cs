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
    public partial class Form1 : Form
    {
        public static Form1 objInterface = new Form1();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void band3Button_Click(object sender, EventArgs e)
        {
            ResistorCode.objResistor.Show();
            objInterface = this;
            this.Hide();
        }

        private void band4Button_Click(object sender, EventArgs e)
        {
            Form2.objBand4.Show();
            objInterface = this;
            this.Hide();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a nice day!", "Resistor Calculator");     
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.objInterface.Show();
        }
    }
}
