using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CosmanLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Dallas Cosman
         * October 4, 2022
         * This program is both a simple multiplication calculator, and displays
         * an image and gives some information about a certain topic */
        private void btnExit_Click(object sender, EventArgs e)
        {
            //on exit button press close the form (this)
            this.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //on picture button press show the image and hide the data label
            picImage.Visible = true;
            lblData.Visible = false;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //on hide button press hide both the image and the data label
            picImage.Visible = false;
            lblData.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //on reset button press reset the text boxes and the answer label
            txtNumber.Clear();
            txtMultiplier.Clear();
            lblAnswer.Text = "";
            txtNumber.Focus();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //on data button press hide the image and show the data label containing a brief description
            //Change created here------------------------------------------------------------------------------------
            lblData.Visible = true;
            picImage.Visible = false;
            lblData.Text = "My topic is " + lblTopic.Text + "This text has been changed"; //<---------------
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            //when you click the image show a message box named Dallas, containing some info on the image
            MessageBox.Show("This is a picture of me (#8) with a few of my teamates.", "Dallas");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*on calculate button press multiplies the number box with the multiplier box
              and shows the answer in the answer label*/
            int number, multiplier, answer;
            number = Convert.ToInt32(txtNumber.Text);
            multiplier = Convert.ToInt32(txtMultiplier.Text);
            answer = number * multiplier;
            lblAnswer.Text = Convert.ToString(answer);
        }
    }
}
