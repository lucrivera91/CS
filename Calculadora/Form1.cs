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
            TxtScreen.Clear();
            TxtScreen.Text = "0";
        }

        //Presionar el boton resultado al apretar enter
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (ActiveControl.GetType() == typeof(Button) && ActiveControl != AcceptButton)
                {
                    ActiveControl = AcceptButton as Button;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        double result = 0;
        string op = "";
        bool isOpPerformed = false;

        private void BtnExp_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if ((TxtScreen.Text == "0" && btn.Text != ",") || isOpPerformed)
            {
                TxtScreen.Clear();
                isOpPerformed = false;
            }

            switch (btn.Text)
            {
                case "0":
                    {
                        if (TxtScreen.TextLength <= 15 && (TxtScreen.TextLength > 0 || TxtScreen.Text != "0"))
                            TxtScreen.Text += btn.Text;
                        break;
                    }
                case ",":
                    {
                        if (TxtScreen.TextLength <= 15 && !TxtScreen.Text.Contains(","))
                            TxtScreen.Text += btn.Text;
                        break;
                    }
                default:
                    {
                        if (TxtScreen.TextLength <= 15)
                            TxtScreen.Text += btn.Text;
                        break;
                    }
            }  
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtScreen.Clear();
            TxtScreen.Text = "0";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtScreen.Clear();
            TxtScreen.Text = "0";
            lblOp.Text = string.Empty;
            result = 0;
            isOpPerformed = false;
            op = "";
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (TxtScreen.TextLength == 1)
            {
                TxtScreen.Text = "0";
            }

            if (TxtScreen.Text != "0" && TxtScreen.TextLength > 1) 
            {
                string del = TxtScreen.Text.Substring(0, TxtScreen.TextLength - 1);
                TxtScreen.Text = del;
            }
        }

        private void BtnOp_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (result != 0 && isOpPerformed == false)
            {
                    BtnResult.PerformClick();
                    op = btn.Text;
                    lblOp.Text = result + " " + op;
                    isOpPerformed = true;
            }
            else
            {
                op = btn.Text;
                result = double.Parse(TxtScreen.Text);
                lblOp.Text = result + " " + op;
                isOpPerformed = true;
            }
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    {
                        TxtScreen.Text = (result + double.Parse(TxtScreen.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        TxtScreen.Text = (result - double.Parse(TxtScreen.Text)).ToString();
                        break;
                    }
                case "x":
                    {
                        TxtScreen.Text = (result * double.Parse(TxtScreen.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        if (TxtScreen.Text != "0")
                        {
                            TxtScreen.Text = (result / double.Parse(TxtScreen.Text)).ToString();
                        }
                        break;
                    }
            }
            result = double.Parse(TxtScreen.Text);
            lblOp.Text = result.ToString() + " " + op;
            op = "";
        }

        private void FormCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1': Btn1.PerformClick(); break;
                case '2': Btn2.PerformClick(); break;
                case '3': Btn3.PerformClick(); break;
                case '4': Btn4.PerformClick(); break;
                case '5': Btn5.PerformClick(); break;
                case '6': Btn6.PerformClick(); break;
                case '7': Btn7.PerformClick(); break;
                case '8': Btn8.PerformClick(); break;
                case '9': Btn9.PerformClick(); break;
                case '0': Btn0.PerformClick(); break;
                case ',': BtnComa.PerformClick(); break;
                case '.': BtnComa.PerformClick(); break;
                case '/': BtnDiv.PerformClick(); break;
                case '*': BtnX.PerformClick(); break;
                case '-': BtnSub.PerformClick(); break;
                case '+': BtnAdd.PerformClick(); break;
                case '=': BtnResult.PerformClick(); break;
                default: break;
            }
        }

        private void FormCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back: BtnDel.PerformClick(); break;
                case Keys.Delete: BtnCE.PerformClick(); break;
                case Keys.Escape: BtnClear.PerformClick(); break;
                case Keys.Enter: BtnResult.PerformClick(); break;
                default: break;
            }
        }
    }
}