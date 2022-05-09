namespace Calculadora1
{
    partial class Form1
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
            this.textResultado = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btn_digno_diagonal = new System.Windows.Forms.Button();
            this.btn_signo_asterisco = new System.Windows.Forms.Button();
            this.btn_signo_menos = new System.Windows.Forms.Button();
            this.btnmas = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_signo_igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textResultado
            // 
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.Location = new System.Drawing.Point(0, 12);
            this.textResultado.MaxLength = 20;
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.Size = new System.Drawing.Size(261, 27);
            this.textResultado.TabIndex = 0;
            this.textResultado.Tag = "0";
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 221);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 45);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 170);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 45);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(114, 170);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 45);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(63, 170);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 45);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(63, 117);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 45);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(114, 119);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 45);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 117);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 45);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(63, 66);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 45);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(114, 66);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 45);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 66);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 45);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnpunto
            // 
            this.btnpunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpunto.Location = new System.Drawing.Point(114, 221);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(45, 45);
            this.btnpunto.TabIndex = 11;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btn_digno_diagonal
            // 
            this.btn_digno_diagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_digno_diagonal.Location = new System.Drawing.Point(165, 66);
            this.btn_digno_diagonal.Name = "btn_digno_diagonal";
            this.btn_digno_diagonal.Size = new System.Drawing.Size(45, 45);
            this.btn_digno_diagonal.TabIndex = 12;
            this.btn_digno_diagonal.Tag = "/";
            this.btn_digno_diagonal.Text = "/";
            this.btn_digno_diagonal.UseVisualStyleBackColor = true;
            this.btn_digno_diagonal.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_signo_asterisco
            // 
            this.btn_signo_asterisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signo_asterisco.Location = new System.Drawing.Point(165, 119);
            this.btn_signo_asterisco.Name = "btn_signo_asterisco";
            this.btn_signo_asterisco.Size = new System.Drawing.Size(45, 45);
            this.btn_signo_asterisco.TabIndex = 13;
            this.btn_signo_asterisco.Tag = "*";
            this.btn_signo_asterisco.Text = "*";
            this.btn_signo_asterisco.UseVisualStyleBackColor = true;
            this.btn_signo_asterisco.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_signo_menos
            // 
            this.btn_signo_menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signo_menos.Location = new System.Drawing.Point(165, 170);
            this.btn_signo_menos.Name = "btn_signo_menos";
            this.btn_signo_menos.Size = new System.Drawing.Size(45, 45);
            this.btn_signo_menos.TabIndex = 14;
            this.btn_signo_menos.Tag = "-";
            this.btn_signo_menos.Text = "-";
            this.btn_signo_menos.UseVisualStyleBackColor = true;
            this.btn_signo_menos.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnmas
            // 
            this.btnmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmas.Location = new System.Drawing.Point(165, 221);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(45, 45);
            this.btnmas.TabIndex = 15;
            this.btnmas.Tag = "+";
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.clickoperador);
            // 
            // btn_CE
            // 
            this.btn_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CE.Location = new System.Drawing.Point(216, 66);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(45, 45);
            this.btn_CE.TabIndex = 16;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_c
            // 
            this.btn_c.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.Location = new System.Drawing.Point(216, 117);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(45, 45);
            this.btn_c.TabIndex = 17;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_signo_igual
            // 
            this.btn_signo_igual.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signo_igual.Location = new System.Drawing.Point(216, 168);
            this.btn_signo_igual.Name = "btn_signo_igual";
            this.btn_signo_igual.Size = new System.Drawing.Size(45, 98);
            this.btn_signo_igual.TabIndex = 18;
            this.btn_signo_igual.Text = "=";
            this.btn_signo_igual.UseVisualStyleBackColor = true;
            this.btn_signo_igual.Click += new System.EventHandler(this.btn_signo_igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 277);
            this.Controls.Add(this.btn_signo_igual);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.btn_signo_menos);
            this.Controls.Add(this.btn_signo_asterisco);
            this.Controls.Add(this.btn_digno_diagonal);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.textResultado);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btn_digno_diagonal;
        private System.Windows.Forms.Button btn_signo_asterisco;
        private System.Windows.Forms.Button btn_signo_menos;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_signo_igual;
    }
}

