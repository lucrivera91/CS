using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtPantalla.Clear();
            TxtPantalla.Text = 0.ToString();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text == 0.ToString())
            {
                TxtPantalla.Clear();
            }
            
            if(TxtPantalla.TextLength <= 15)
            {
                TxtPantalla.Text += 7;
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text == 0.ToString())
            {
                TxtPantalla.Clear();
            }

            if (TxtPantalla.TextLength <= 15)
            {
                TxtPantalla.Text += 8;
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text == 0.ToString())
            {
                TxtPantalla.Clear();
            }

            if (TxtPantalla.TextLength <= 15)
            {
                TxtPantalla.Text += 9;
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text == 0.ToString())
            {
                TxtPantalla.Clear();
            }

            if (TxtPantalla.TextLength <= 15)
            {
                TxtPantalla.Text += 4;
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text == 0.ToString())
            {
                TxtPantalla.Clear();
            }

            if (TxtPantalla.TextLength <= 15)
            {
                TxtPantalla.Text += 5;
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text == 0.ToString())
            {
                TxtPantalla.Clear();
            }

            if (TxtPantalla.TextLength <= 15)
            {
                TxtPantalla.Text += 6;
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text == 0.ToString())
            {
                TxtPantalla.Clear();
            }

            if (TxtPantalla.TextLength <= 15)
            {
                TxtPantalla.Text += 1;
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text == 0.ToString())
            {
                TxtPantalla.Clear();
            }

            if (TxtPantalla.TextLength <= 15)
            {
                TxtPantalla.Text += 2;
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text == 0.ToString())
            {
                TxtPantalla.Clear();
            }

            if (TxtPantalla.TextLength <= 15)
            {
                TxtPantalla.Text += 3;
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.TextLength >= 1 && TxtPantalla.TextLength <= 15 && TxtPantalla.Text != 0.ToString())
            {
                TxtPantalla.Text += 0;
            }
        }
    }
}
