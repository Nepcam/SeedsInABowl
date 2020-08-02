using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seeds_in_a_bowl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Name: Cameron Nepe
        //ID  : 1262199

        //size of seed
        const int SEED_SIZE = 40;

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear the textbox and set the focus
            textBoxNumSeeds.Clear();
            textBoxNumSeeds.Focus();
            //Refresh the picture display
            pictureBoxBowl.Refresh();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
