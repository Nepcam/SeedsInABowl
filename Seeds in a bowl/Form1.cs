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
        const int SEED_SIZE = 150;
        const int GAP_SIZE = 10;
        const int DISPLAY_WIDTH = 0;
        const int DISPLAY_HEIGHT = 0;
        const int DISPLAY_LEFT = 10;
        const int DISPLAY_TOP = 10;
        const int ROW = 550;

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            //Variables
            int seeds = 0;
            //Graphics
            Graphics paper = pictureBoxBowl.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Yellow);
            int x = DISPLAY_LEFT;
            int y = DISPLAY_TOP;
            int f = 0;

            //Get number of seeds from UI
            seeds = int.Parse(textBoxNumSeeds.Text);
            try
            {
                if (seeds <= ROW);
                {
                    for (int line = 0; line <= ROW; line++)
                    {
                        //Draw grid of seeds
                        for (int i = 0; i <= ROW; i++)
                        {
                            paper.FillEllipse(brush, x, y, SEED_SIZE, SEED_SIZE);
                            x += SEED_SIZE + GAP_SIZE;
                            //y += SEED_SIZE + GAP_SIZE;
                        }
                        //y += SEED_SIZE + GAP_SIZE;
                    }
                    y += SEED_SIZE + GAP_SIZE;
                } 
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
                textBoxNumSeeds.Clear();
                pictureBoxBowl.Refresh();
            }
        }

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
