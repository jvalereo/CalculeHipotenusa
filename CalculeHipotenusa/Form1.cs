using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalculeHipotenusa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            /*Treinamento - Calcule a Hipotenusa do triangulo retangulo, tipo double*/
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo double

            double hipotenusa, catetoOposto, catetoAdjacente;


            //Declarando entrada de dado no textbox

            catetoOposto = double.Parse(textBoxOposto.Text, CultureInfo.InvariantCulture);
            catetoAdjacente = double.Parse(textBoxAdjacenter.Text, CultureInfo.InvariantCulture);


            //Declarando a variavel Hipotenusa

            hipotenusa = Math.Pow(catetoOposto, 2.0) + Math.Pow(catetoAdjacente, 2.0);



            //imprimir saida de dados no MessagemBox, concatenação

            MessageBox.Show("O valor da Hipotenusa = " + hipotenusa.ToString("F1", CultureInfo.InvariantCulture),
                "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Teste de Novo!!!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando o codigo limpar, textbox, focus

            textBoxOposto.Text = " ";
            textBoxAdjacenter.Text = " ";
            textBoxOposto.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo sair do programa

            Close();

        }

        //Fim do programa
    }
}
