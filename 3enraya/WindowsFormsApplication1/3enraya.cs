using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //inicializamos las varibles
        public int turno = 0;

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (turno % 2 == 0)
            {
                pic1x.Visible = true;
            }
            else
            {
                pic1o.Visible = true;
            }
            btn1.Enabled = false;
            turno++;
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (turno % 2 == 0)
            {
                pic2x.Visible = true;
            }
            else
            {
                pic2o.Visible = true;
            }
            btn2.Enabled = false;
            turno++;

        }

        private void btn3_Click(object sender, EventArgs e)
        {


            if (turno % 2 == 0)
            {
                pic3x.Visible = true;
            }
            else
            {
                pic3o.Visible = true;
            }
            btn3.Enabled = false;
            turno++;

        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (turno % 2 == 0)
            {
                pic4x.Visible = true;
            }
            else
            {
                pic4o.Visible = true;
            }
            btn4.Enabled = false;
            turno++;

        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (turno % 2 == 0)
            {
                pic5x.Visible = true;
            }
            else
            {
                pic5o.Visible = true;
            }
            btn5.Enabled = false;
            turno++;

        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (turno % 2 == 0)
            {
                pic6x.Visible = true;
            }
            else
            {
                pic6o.Visible = true;
            }
            btn6.Enabled = false;
            turno++;


        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (turno % 2 == 0)
            {
                pic7x.Visible = true;
            }
            else
            {
                pic7o.Visible = true;
            }
            btn7.Enabled = false;
            turno++;

        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (turno % 2 == 0)
            {
                pic8x.Visible = true;
            }
            else
            {
                pic8o.Visible = true;
            }
            btn8.Enabled = false;
            turno++;

        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (turno % 2 == 0)
            {
                pic9x.Visible = true;
            }
            else
            {
                pic9o.Visible = true;
            }
            btn9.Enabled = false;
            turno++;

        }

      

    }
}
