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
            TxtPantalla.Clear();
            TxtPantalla.Text = "0";
        }

        private void BtnExp_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (TxtPantalla.Text == "0" && btn.Text != ",")
                TxtPantalla.Clear();

            switch (btn.Text)
            {
                case "0":
                    {
                        if (TxtPantalla.TextLength <= 15 && (TxtPantalla.TextLength > 0 || TxtPantalla.Text != "0"))
                            TxtPantalla.Text += btn.Text;
                        break;
                    }
                case ",":
                    {
                        if (TxtPantalla.TextLength <= 15 && !TxtPantalla.Text.Contains(","))
                            TxtPantalla.Text += btn.Text;
                        break;
                    }
                default:
                    {
                        if (TxtPantalla.TextLength <= 15)
                            TxtPantalla.Text += btn.Text;
                        break;
                    }
            }  
        }

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
            
        }

        /*private void BtnDiv_Click(object sender, EventArgs e)
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
        }*/
    }
}
