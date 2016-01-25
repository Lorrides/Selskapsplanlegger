using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selskapsplanlegger
{
    public partial class Form1 : Form
    {
        MiddagsSelskap middagsSelskap;


        public Form1()
        {
            InitializeComponent();
            middagsSelskap = new MiddagsSelskap() { NumberOfPeople = 5 };
            middagsSelskap.CalculateCostOfDecorations ( fancyBox.Checked);
            middagsSelskap.SetHealthyPotion(healthyBox.Checked);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            middagsSelskap.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerParrtyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            middagsSelskap.SetHealthyPotion(healthyBox.Checked);
            DisplayDinnerParrtyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            middagsSelskap.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerParrtyCost();
        }

        private void DisplayDinnerParrtyCost()
        {
            decimal Kost = middagsSelskap.CalculateCost(healthyBox.Checked);
            kost.Text = Kost.ToString("c");
        }


    }
}
