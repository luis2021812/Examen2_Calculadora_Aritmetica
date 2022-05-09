using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char operador;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (textResultado.Text == "0")
                textResultado.Text = "";

            textResultado.Text += boton.Text;
             
        }

        private void btn_signo_igual_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(textResultado.Text);

            if (operador == '+')
            {
                textResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }

            if (operador == '-')
            {
                textResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }

            if (operador == '*')
            {
                textResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }

            if (operador == '/')
            {
                textResultado.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(textResultado.Text);
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            operador = '\0';
            textResultado.Text = "0";
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textResultado.Text = "0";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (!textResultado.Text.Contains("."))
            {
                textResultado.Text +=".";
            }
        }

        public void clickoperador(object sender, EventArgs e) 
        {
            var boton = (Button)sender;

            Numero1 = Convert.ToDouble(textResultado.Text);
            operador = Convert.ToChar(boton.Tag);

            textResultado.Text = "0";
        }

    }
}
