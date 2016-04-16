using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Project:     Lab 2 Ace Descriptions
 * Programmer:  Julie Green
 * Date:        April 8, 2016
 * Purpose:     Displays the type of Ace card selected
 */

namespace JulieGreenLab2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            lblCard.Text = "Ace of Spades";

            pic1.BackColor = Color.Black;
            pic2.BackColor = Color.Transparent;
            pic3.BackColor = Color.Transparent;
            pic4.BackColor = Color.Transparent;

            pic1.BorderStyle = BorderStyle.Fixed3D;
            pic2.BorderStyle = BorderStyle.None;
            pic3.BorderStyle = BorderStyle.None;
            pic4.BorderStyle = BorderStyle.None;
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            lblCard.Text = "Ace of Hearts";

            pic1.BackColor = Color.Transparent;
            pic2.BackColor = Color.Black;
            pic3.BackColor = Color.Transparent;
            pic4.BackColor = Color.Transparent;

            pic1.BorderStyle = BorderStyle.None;
            pic2.BorderStyle = BorderStyle.Fixed3D;
            pic3.BorderStyle = BorderStyle.None;
            pic4.BorderStyle = BorderStyle.None;
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            lblCard.Text = "Ace of Clubs";

            pic1.BackColor = Color.Transparent;
            pic2.BackColor = Color.Transparent;
            pic3.BackColor = Color.Black;
            pic4.BackColor = Color.Transparent;

            pic1.BorderStyle = BorderStyle.None;
            pic2.BorderStyle = BorderStyle.None;
            pic3.BorderStyle = BorderStyle.Fixed3D;
            pic4.BorderStyle = BorderStyle.None;
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            lblCard.Text = "Ace of Diamonds";

            pic1.BackColor = Color.Transparent;
            pic2.BackColor = Color.Transparent;
            pic3.BackColor = Color.Transparent;
            pic4.BackColor = Color.Black;

            pic1.BorderStyle = BorderStyle.None;
            pic2.BorderStyle = BorderStyle.None;
            pic3.BorderStyle = BorderStyle.None;
            pic4.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
