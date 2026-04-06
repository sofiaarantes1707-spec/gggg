using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos 
{
    public partial class CalculadoraPlus : Form
    {
        decimal vNumAnt;
        string vOperacao;
        bool vLimparVisor;
        decimal vNumAtual;
        public CalculadoraPlus()
        {
            InitializeComponent();
        }
        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void f_digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;
            if (lblVisor.Text == "0" || vLimparVisor)
            //se a pessoa apertar 0 vai limpar ou:
            {
                lblVisor.Text = "";
                vLimparVisor = false;
                //se a pessoa escerver nada
            }
            lblVisor.Text += digito; //em cadeia

            lblHistorico.Text = vNumAnt + " ";
            this.ActiveControl = null; 
            //ou //lblVisor.Focus();
            //apertar o botao - nao deixar o foco no botão
            //o enter executa o botao que tem o foco, entao se tiver o foco no botao 1, o enter vai apertar o 1
        }
        private void f_operacoes(object sender, EventArgs e)
        { 
            // tenta salvar o número atual antes de operar
            //if (!decimal.TryParse(lblVisor.Text, out vNumAnt))
            //{
              //  vNumAnt = 0;
            //}
            //vOperacao = ((Button)sender).Text;
            //vLimparVisor = true;

            vNumAnt = decimal.Parse(lblVisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimparVisor = true; //intrução de atribuição - atribui o valor verdadeiro
            this.ActiveControl = null;
            lblHistorico.Text = vNumAnt + " " + vOperacao;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            // adicionar vírgula apenas se ainda não existir
            if (!lblVisor.Text.Contains(","))
            {
                if (vLimparVisor)
                {
                    lblVisor.Text = " ";
                    vLimparVisor = false;
                }
                lblVisor.Text += ",";
            }
        }

        private void btnLimpar_Click (object sender, EventArgs e)
        {
            lblHistorico.Text = "";
            lblVisor.Text = "0";
            vOperacao = null;
            vLimparVisor = false;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lblVisor.Text.Length > 1)
            {
                lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            }
            else
            {
                lblVisor.Text = "0";
            }
        }

        private void CalculadoraPlus_Load(object sender, EventArgs e)
        {

        }

        private void lblVisor_Click(object sender, EventArgs e)
        {

        }
        private void CalculadoraPlus_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();
            //quando a pessoa apertar uma tecla, o label1 vai mostrar qual tecla foi apertada
            //como o cshar ve o codigo das teclas dentro do keydown
            Button botao = new Button();
            if (e.KeyCode == Keys.Escape) //esc
            {
                Close();
            }
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                botao.Text = e.KeyCode.ToString().Substring(6);
                f_digitos(botao, e); // a funcao f digitos precisa dos objetos e do argumento
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button21_Click(object sender, EventArgs e)
        {

        }
        private void bntigual_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);
            //decidir que operaçao realizar
            switch (vOperacao)
            {
                case "+":
                    lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                    break;
                case "-":
                    lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                    break;
                case "*":
                    break;
                    case "/":
                    break;
                case "^":
                    break;
                    lblHistorico.Text = vNumAnt + " " + vOperacao + " " + vNumAtual + " " + "=";

            }
        }

        private void CalculadoraPlus_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Control botao in this.Controls)
            {
                if (botao is Button)
                {
                   botao.BackColor = SystemColors.Control; //cor padrão do botão
                }
            }
        }
            //lblHistorico.Text = vNumAnt + " " + vOperacao + " " + vNumAtual + " " + "=";
       
        //PESQUISA:pedir para IA fazer esse código e comparar o que ela fez com 
        //o que fizemos em aula. Em dupla, enviar o git (o video e a pesquisa dentro do
        //git).
    }
}
