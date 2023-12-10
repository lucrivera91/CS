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
            this.TxtPantalla = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnComa = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnX = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnResultado = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPantalla
            // 
            this.TxtPantalla.Location = new System.Drawing.Point(13, 13);
            this.TxtPantalla.MaxLength = 16;
            this.TxtPantalla.Name = "TxtPantalla";
            this.TxtPantalla.ReadOnly = true;
            this.TxtPantalla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPantalla.Size = new System.Drawing.Size(283, 20);
            this.TxtPantalla.TabIndex = 0;
            this.TxtPantalla.Text = "0";
            this.TxtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.BtnResultado);
            this.Panel.Controls.Add(this.BtnSuma);
            this.Panel.Controls.Add(this.BtnResta);
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
            this.Panel.Location = new System.Drawing.Point(13, 40);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(283, 249);
            this.Panel.TabIndex = 1;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(3, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(54, 42);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(214, 3);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(54, 42);
            this.BtnDel.TabIndex = 1;
            this.BtnDel.Text = "<";
            this.BtnDel.UseVisualStyleBackColor = true;
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(3, 51);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(54, 42);
            this.Btn7.TabIndex = 2;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(63, 51);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(54, 42);
            this.Btn8.TabIndex = 3;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(123, 51);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(54, 42);
            this.Btn9.TabIndex = 4;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(123, 99);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(54, 42);
            this.Btn6.TabIndex = 7;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(63, 99);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(54, 42);
            this.Btn5.TabIndex = 6;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(3, 99);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(54, 42);
            this.Btn4.TabIndex = 5;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(123, 147);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(54, 42);
            this.Btn3.TabIndex = 10;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(63, 147);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(54, 42);
            this.Btn2.TabIndex = 9;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(3, 147);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(54, 42);
            this.Btn1.TabIndex = 8;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnComa
            // 
            this.BtnComa.Location = new System.Drawing.Point(3, 195);
            this.BtnComa.Name = "BtnComa";
            this.BtnComa.Size = new System.Drawing.Size(54, 42);
            this.BtnComa.TabIndex = 13;
            this.BtnComa.Text = ",";
            this.BtnComa.UseVisualStyleBackColor = true;
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(63, 195);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(54, 42);
            this.Btn0.TabIndex = 12;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnSuma
            // 
            this.BtnSuma.Location = new System.Drawing.Point(214, 195);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(54, 42);
            this.BtnSuma.TabIndex = 17;
            this.BtnSuma.Text = "+";
            this.BtnSuma.UseVisualStyleBackColor = true;
            // 
            // BtnResta
            // 
            this.BtnResta.Location = new System.Drawing.Point(214, 147);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(54, 42);
            this.BtnResta.TabIndex = 16;
            this.BtnResta.Text = "-";
            this.BtnResta.UseVisualStyleBackColor = true;
            // 
            // BtnX
            // 
            this.BtnX.Location = new System.Drawing.Point(214, 99);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(54, 42);
            this.BtnX.TabIndex = 15;
            this.BtnX.Text = "X";
            this.BtnX.UseVisualStyleBackColor = true;
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(214, 51);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(54, 42);
            this.BtnDiv.TabIndex = 14;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            // 
            // BtnResultado
            // 
            this.BtnResultado.Location = new System.Drawing.Point(123, 195);
            this.BtnResultado.Name = "BtnResultado";
            this.BtnResultado.Size = new System.Drawing.Size(54, 42);
            this.BtnResultado.TabIndex = 18;
            this.BtnResultado.Text = "=";
            this.BtnResultado.UseVisualStyleBackColor = true;
            // 
            // FormCalculadora
            // 
            this.AcceptButton = this.BtnResultado;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(304, 297);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.TxtPantalla);
            this.Name = "FormCalculadora";
            this.Text = "Calculadora";
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPantalla;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button BtnResultado;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnResta;
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
    }
}

