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

        double exp1 = 0;
        double exp2 = 0;
        double resultado = 0;

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtPantalla.Clear();
            TxtPantalla.Text = "0";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtPantalla.Clear();
            TxtPantalla.Text = "0";
            lblOp.Text = string.Empty;
            exp1 = 0;
            exp2 = 0;
            resultado = 0;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text == "0" || TxtPantalla.Text == resultado.ToString())
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
            if (TxtPantalla.Text == "0" || TxtPantalla.Text == resultado.ToString())
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
            if (TxtPantalla.Text == "0" || TxtPantalla.Text == resultado.ToString())
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
            if (TxtPantalla.Text == "0" || TxtPantalla.Text == resultado.ToString())
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
            if (TxtPantalla.Text == "0" || TxtPantalla.Text == resultado.ToString())
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
            if (TxtPantalla.Text == "0" || TxtPantalla.Text == resultado.ToString())
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
            if (TxtPantalla.Text == "0" || TxtPantalla.Text == resultado.ToString())
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
            if (TxtPantalla.Text == "0" || TxtPantalla.Text == resultado.ToString())
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
            if (TxtPantalla.Text == "0" || TxtPantalla.Text == resultado.ToString())
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
            if (TxtPantalla.TextLength > 0 && TxtPantalla.TextLength <= 15 && TxtPantalla.Text != "0")
            {
                TxtPantalla.Text += 0;
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.TextLength == 1)
            {
                TxtPantalla.Text = "0";
            }

            if (TxtPantalla.Text != "0" && TxtPantalla.TextLength > 1) 
            {
                string borrar = TxtPantalla.Text.Substring(0, TxtPantalla.TextLength - 1);
                TxtPantalla.Text = borrar;
            }
        }

        private void BtnComa_Click(object sender, EventArgs e)
        {
            if (!TxtPantalla.Text.Contains(","))
            {
                TxtPantalla.Text += ",";
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (TxtPantalla.Text != "0")
            {
                if (resultado == 0)
                {
                    exp1 = double.Parse(TxtPantalla.Text);
                    lblOp.Text = exp1 + " /";
                    lblOp.Visible = true;
                    TxtPantalla.Text = "0";
                    resultado = exp1;
                }
                else
                {
                    if (lblOp.Visible == true)
                    {
                        exp2 = double.Parse(TxtPantalla.Text);
                        resultado = resultado / exp2;
                        lblOp.Text = resultado + " /";
                        TxtPantalla.Text = resultado.ToString();
                    }
                }
            }
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            if (resultado == 0)
            {
                exp1 = double.Parse(TxtPantalla.Text);
                lblOp.Text = exp1 + " x";
                lblOp.Visible = true;
                TxtPantalla.Text = "0";
                resultado = exp1;
            }
            else
            {
                if (lblOp.Visible == true)
                {
                    exp2 = double.Parse(TxtPantalla.Text);
                    resultado = resultado * exp2;
                    lblOp.Text = resultado + " x";
                    TxtPantalla.Text = resultado.ToString();
                }
            }
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            if (resultado == 0)
            {
                exp1 = double.Parse(TxtPantalla.Text);
                lblOp.Text = exp1 + " -";
                lblOp.Visible = true;
                TxtPantalla.Text = "0";
                resultado = exp1;
            }
            else
            {
                if (lblOp.Visible == true)
                {
                    exp2 = double.Parse(TxtPantalla.Text);
                    resultado = resultado - exp2;
                    lblOp.Text = resultado + " -";
                    TxtPantalla.Text = resultado.ToString();
                }
            }
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            if (resultado == 0)
            {
                exp1 = double.Parse(TxtPantalla.Text);
                lblOp.Text = exp1 + " +";
                lblOp.Visible = true;
                TxtPantalla.Text = "0";
                resultado = exp1;
            }
            else
            {
                if (lblOp.Visible == true)
                {
                    exp2 = double.Parse(TxtPantalla.Text);
                    resultado = resultado + exp2;
                    lblOp.Text = resultado + " +";
                    TxtPantalla.Text = resultado.ToString();
                }
            }
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            exp2 = double.Parse(TxtPantalla.Text);

            if (lblOp.Text.EndsWith("/"))
            {
                TxtPantalla.Text = (exp1 / exp2).ToString();
            }
            else if (lblOp.Text.EndsWith("x"))
            {
                TxtPantalla.Text = (exp1 * exp2).ToString();
            } else if (lblOp.Text.EndsWith("-"))
            {
                TxtPantalla.Text = (exp1 - exp2).ToString();
            }
            else if (lblOp.Text.EndsWith("+"))
            {
                TxtPantalla.Text = (exp1 + exp2).ToString();
            }
        }
    }
}
