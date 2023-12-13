namespace Calculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtScreen = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnX = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnComa = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtScreen
            // 
            this.TxtScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtScreen.Location = new System.Drawing.Point(15, 51);
            this.TxtScreen.Margin = new System.Windows.Forms.Padding(6);
            this.TxtScreen.MaxLength = 16;
            this.TxtScreen.Name = "TxtScreen";
            this.TxtScreen.ReadOnly = true;
            this.TxtScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtScreen.Size = new System.Drawing.Size(567, 53);
            this.TxtScreen.TabIndex = 1;
            this.TxtScreen.Text = "\r\n0";
            this.TxtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.BtnCE);
            this.Panel.Controls.Add(this.BtnResult);
            this.Panel.Controls.Add(this.BtnAdd);
            this.Panel.Controls.Add(this.BtnSub);
            this.Panel.Controls.Add(this.BtnX);
            this.Panel.Controls.Add(this.BtnDiv);
            this.Panel.Controls.Add(this.BtnComa);
            this.Panel.Controls.Add(this.Btn0);
            this.Panel.Controls.Add(this.Btn3);
            this.Panel.Controls.Add(this.Btn2);
            this.Panel.Controls.Add(this.Btn1);
            this.Panel.Controls.Add(this.Btn6);
            this.Panel.Controls.Add(this.Btn5);
            this.Panel.Controls.Add(this.Btn4);
            this.Panel.Controls.Add(this.Btn9);
            this.Panel.Controls.Add(this.Btn8);
            this.Panel.Controls.Add(this.Btn7);
            this.Panel.Controls.Add(this.BtnDel);
            this.Panel.Controls.Add(this.BtnClear);
            this.Panel.Location = new System.Drawing.Point(15, 116);
            this.Panel.Margin = new System.Windows.Forms.Padding(6);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(567, 479);
            this.Panel.TabIndex = 1;
            // 
            // BtnCE
            // 
            this.BtnCE.Location = new System.Drawing.Point(6, 6);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(6);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(108, 81);
            this.BtnCE.TabIndex = 19;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(246, 375);
            this.BtnResult.Margin = new System.Windows.Forms.Padding(6);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(108, 81);
            this.BtnResult.TabIndex = 18;
            this.BtnResult.Text = "=";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(428, 375);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(108, 81);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnOp_click);
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(428, 283);
            this.BtnSub.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(108, 81);
            this.BtnSub.TabIndex = 16;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnOp_click);
            // 
            // BtnX
            // 
            this.BtnX.Location = new System.Drawing.Point(428, 190);
            this.BtnX.Margin = new System.Windows.Forms.Padding(6);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(108, 81);
            this.BtnX.TabIndex = 15;
            this.BtnX.Text = "x";
            this.BtnX.UseVisualStyleBackColor = true;
            this.BtnX.Click += new System.EventHandler(this.BtnOp_click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(428, 98);
            this.BtnDiv.Margin = new System.Windows.Forms.Padding(6);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(108, 81);
            this.BtnDiv.TabIndex = 14;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnOp_click);
            // 
            // BtnComa
            // 
            this.BtnComa.Location = new System.Drawing.Point(6, 375);
            this.BtnComa.Margin = new System.Windows.Forms.Padding(6);
            this.BtnComa.Name = "BtnComa";
            this.BtnComa.Size = new System.Drawing.Size(108, 81);
            this.BtnComa.TabIndex = 13;
            this.BtnComa.Text = ",";
            this.BtnComa.UseVisualStyleBackColor = true;
            this.BtnComa.Click += new System.EventHandler(this.BtnExp_click);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(126, 375);
            this.Btn0.Margin = new System.Windows.Forms.Padding(6);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(108, 81);
            this.Btn0.TabIndex = 12;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.BtnExp_click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(246, 283);
            this.Btn3.Margin = new System.Windows.Forms.Padding(6);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(108, 81);
            this.Btn3.TabIndex = 10;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.BtnExp_click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(126, 283);
            this.Btn2.Margin = new System.Windows.Forms.Padding(6);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(108, 81);
            this.Btn2.TabIndex = 9;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.BtnExp_click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(6, 283);
            this.Btn1.Margin = new System.Windows.Forms.Padding(6);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(108, 81);
            this.Btn1.TabIndex = 8;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.BtnExp_click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(246, 190);
            this.Btn6.Margin = new System.Windows.Forms.Padding(6);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(108, 81);
            this.Btn6.TabIndex = 7;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.BtnExp_click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(126, 190);
            this.Btn5.Margin = new System.Windows.Forms.Padding(6);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(108, 81);
            this.Btn5.TabIndex = 6;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.BtnExp_click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(6, 190);
            this.Btn4.Margin = new System.Windows.Forms.Padding(6);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(108, 81);
            this.Btn4.TabIndex = 5;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.BtnExp_click);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(246, 98);
            this.Btn9.Margin = new System.Windows.Forms.Padding(6);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(108, 81);
            this.Btn9.TabIndex = 4;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.BtnExp_click);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(126, 98);
            this.Btn8.Margin = new System.Windows.Forms.Padding(6);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(108, 81);
            this.Btn8.TabIndex = 3;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.BtnExp_click);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(6, 98);
            this.Btn7.Margin = new System.Windows.Forms.Padding(6);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(108, 81);
            this.Btn7.TabIndex = 2;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.BtnExp_click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(428, 6);
            this.BtnDel.Margin = new System.Windows.Forms.Padding(6);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(108, 81);
            this.BtnDel.TabIndex = 1;
            this.BtnDel.Text = "<";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(126, 6);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(6);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(108, 81);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblOp
            // 
            this.lblOp.AutoEllipsis = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblOp.Location = new System.Drawing.Point(15, 9);
            this.lblOp.Name = "lblOp";
            this.lblOp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOp.Size = new System.Drawing.Size(567, 20);
            this.lblOp.TabIndex = 0;
            this.lblOp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormCalculadora
            // 
            this.AcceptButton = this.BtnResult;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(604, 604);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.TxtScreen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCalculadora";
            this.Text = "Calculadora";
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtScreen;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnX;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnComa;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Label lblOp;
    }
}

