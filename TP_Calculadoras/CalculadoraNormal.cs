using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Calculadoras
{
    public partial class CalculadoraNormal : Form
    {
        double valor = 0;
        string operacao = "";
        DataTable Calc = new DataTable();

        public CalculadoraNormal()
        {
            InitializeComponent();
        }

        private void CalculadoraNormal_Load(object sender, EventArgs e)
        {

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (text_entrada_valor.Text == "0")
            {
                text_entrada_valor.Clear();
            }
            text_entrada_valor.Text = text_entrada_valor.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (text_entrada_valor.Text == "0")
            {
                text_entrada_valor.Clear();
            }
            text_entrada_valor.Text = text_entrada_valor.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {   
            if (text_entrada_valor.Text == "0")
            {
                text_entrada_valor.Clear();
            }
            text_entrada_valor.Text = text_entrada_valor.Text + "9";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {   
            if (text_entrada_valor.Text == "0" )
            {
                text_entrada_valor.Clear();
            }
            text_entrada_valor.Text = text_entrada_valor.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {   
            if (text_entrada_valor.Text == "0")
            {
                text_entrada_valor.Clear();
            }
            text_entrada_valor.Text = text_entrada_valor.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {   
            if (text_entrada_valor.Text == "0")
            {
                text_entrada_valor.Clear();
            }   
            text_entrada_valor.Text = text_entrada_valor.Text + "6";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {   
            if (text_entrada_valor.Text == "0")
            {
                text_entrada_valor.Clear();
            }
            text_entrada_valor.Text = text_entrada_valor.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {   
            if (text_entrada_valor.Text == "0" )
            {
                text_entrada_valor.Clear();
            }   
            text_entrada_valor.Text = text_entrada_valor.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (text_entrada_valor.Text == "0")
            {
                text_entrada_valor.Clear();
            }
            text_entrada_valor.Text = text_entrada_valor.Text + "3";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            text_entrada_valor.Text = String.Empty;
            text_entrada_valor.Focus();
            text_entrada_valor.Text = "0";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            if (text_entrada_valor.Text == "0" )
            {
                text_entrada_valor.Clear();
            }
            text_entrada_valor.Text = text_entrada_valor.Text + "0";
        }
         
        private void btn_igual_Click(object sender, EventArgs e)
        {
            lbl_print.Text = " ";
            switch (operacao)
            {
                case "+":
                    text_entrada_valor.Text = (valor + Convert.ToDouble(text_entrada_valor.Text)).ToString();
                    break;
                case "-":
                    text_entrada_valor.Text = (valor - Convert.ToDouble(text_entrada_valor.Text)).ToString();
                    break;
                case "*":
                    text_entrada_valor.Text = (valor * Convert.ToDouble(text_entrada_valor.Text)).ToString();
                    break;
                case "/":
                    text_entrada_valor.Text = (valor / Convert.ToDouble(text_entrada_valor.Text)).ToString();
                    break;
            };
            
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {

            operacao = "+";
            valor = Double.Parse(text_entrada_valor.Text);
            text_entrada_valor.Clear();
            lbl_print.Text = valor + " " + operacao;

        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {

            operacao = "-";
            valor = Double.Parse(text_entrada_valor.Text);
            text_entrada_valor.Clear();
            lbl_print.Text = valor + " " + operacao;
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {

            operacao = "*";
            valor = Double.Parse(text_entrada_valor.Text);
            text_entrada_valor.Clear();
            lbl_print.Text = valor + " " + operacao;
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {

            operacao = "/";
            valor = Double.Parse(text_entrada_valor.Text);
            text_entrada_valor.Clear();
            lbl_print.Text = valor + " " + operacao;
        }

        private void text_entrada_valor_TextChanged(object sender, EventArgs e)
        {

        }
       
        
    }
}
