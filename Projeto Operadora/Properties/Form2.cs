using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Operadora.Properties
{
    public partial class Frm_Valores : Form
    {
        public Frm_Valores()
        {
           
            InitializeComponent();
            Grp_Valores.BackColor = Color.LightGray; //Cores de fundo quando etiver desativado
            Grp_Dados_da_Recarga.BackColor = Color.LightGray; //Cores de fundo quando etiver desativado
            Grp_Operadoras.BackColor  = Color.LightGray; //Cores de fundo quando etiver desativado
            Lbl_Valor_da_Recarga.ForeColor = Color.White; //Deixar a cor das letras brancas


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Pc_Logo_de_Bob.Image = Properties.Resources.oi_removebg_preview; //Imagem da Oi
            BackColor = Color.DarkOrange; //Cores da oi
            Grp_Dados_da_Recarga.BackColor = Color.DarkOrange; //Cores da oi
            Grp_Operadoras.BackColor = Color.DarkOrange; //Cores da oi
            Grp_Valores.BackColor = Color.DarkOrange; //Cores da oi
            Btn_Valor_1.FlatAppearance.BorderColor = Color.Gold; Btn_Valor_1.ForeColor = Color.Gold; //Cores da oi
            Btn_Valor_2.FlatAppearance.BorderColor = Color.Gold; Btn_Valor_2.ForeColor = Color.Gold; //Cores da oi
            Btn_Valor_3.FlatAppearance.BorderColor = Color.Gold; Btn_Valor_3.ForeColor = Color.Gold; //Cores da oi
            Btn_Valor_4.FlatAppearance.BorderColor = Color.Gold; Btn_Valor_4.ForeColor = Color.Gold; //Cores da oi
            Btn_Valor_5.FlatAppearance.BorderColor = Color.Gold; Btn_Valor_5.ForeColor = Color.Gold; //Cores da oi
            Btn_Valor_6.FlatAppearance.BorderColor = Color.Gold; Btn_Valor_6.ForeColor = Color.Gold; //Cores da oi
            Btn_Valor_7.FlatAppearance.BorderColor = Color.Gold; Btn_Valor_7.ForeColor = Color.Gold; //Cores da oi
            Btn_Valor_8.FlatAppearance.BorderColor = Color.Gold; Btn_Valor_8.ForeColor = Color.Gold; //Cores da oi
            Txt_Operadora.Text = "Oi"; //Texto para o Txt_Operadora
            Btn_Valor_1.Text = "12 reais"; Lbl_Validade_1.Text = "30 dias";  //Texto para o Txt de valor
            Btn_Valor_2.Text = "15 reais"; Lbl_Validade_2.Text = "30 dias";  //Texto para o Txt de valor
            Btn_Valor_3.Text = "20 reais"; Lbl_Validade_3.Text = "45 dias";  //Texto para o Txt de valor
            Btn_Valor_4.Text = "25 reais"; Lbl_Validade_4.Text = "45 dias";  //Texto para o Txt de valor
            Btn_Valor_5.Text = "30 reais"; Lbl_Validade_5.Text = "90 dias";  //Texto para o Txt de valor
            Btn_Valor_6.Text = "35 reais"; Lbl_Validade_6.Text = "90 dias";  //Texto para o Txt de valor
            Btn_Valor_7.Text = "40 reais"; Lbl_Validade_7.Text = "90 dias";  //Texto para o Txt de valor
            Btn_Valor_8.Text = "50 reais"; Lbl_Validade_8.Text = "90 dias";  //Texto para o Txt de valor
            Txt_Recarga.Text = "";  //Remover o texto
            Grp_Valores.Enabled = true; //Ativar o grp de valores
            Lbl_Valor_da_Recarga.ForeColor = Color.White;
            Lbl_Valor_da_Recarga.Enabled = false; //Desativando o lbl do valor da recarga
            Txt_Recarga.Enabled = false ;//Desativar o Txt de Valores
            Txt_Recarga.BackColor = Color.Gray; //Cor para o Txt de valores desativado
            Txt_Nome.Text = "Status da Recarga";//Deixar o texto na forma padrão



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Rad_Claro_CheckedChanged(object sender, EventArgs e)
        {
            Pc_Logo_de_Bob.Image = Properties.Resources.Que_não_kkkk_removebg_preview; //Logo da Claro
            BackColor = Color.DarkRed; //Cores de fundo da Claro
            Grp_Dados_da_Recarga.BackColor = Color.DarkRed; //Cores da Claro
            Grp_Operadoras.BackColor = Color.DarkRed; //Cores da Claro
            Grp_Valores.BackColor = Color.DarkRed; //Cores da Claro
            Btn_Valor_1.FlatAppearance.BorderColor = Color.Red; Btn_Valor_1.ForeColor = Color.Red; //Cores da Claro
            Btn_Valor_2.FlatAppearance.BorderColor = Color.Red; Btn_Valor_2.ForeColor = Color.Red; //Cores da Claro
            Btn_Valor_3.FlatAppearance.BorderColor = Color.Red; Btn_Valor_3.ForeColor = Color.Red; //Cores da Claro
            Btn_Valor_4.FlatAppearance.BorderColor = Color.Red; Btn_Valor_4.ForeColor = Color.Red; //Cores da Claro
            Btn_Valor_5.FlatAppearance.BorderColor = Color.Red; Btn_Valor_5.ForeColor = Color.Red; //Cores da Claro
            Btn_Valor_6.FlatAppearance.BorderColor = Color.Red; Btn_Valor_6.ForeColor = Color.Red; //Cores da Claro
            Btn_Valor_7.FlatAppearance.BorderColor = Color.Red; Btn_Valor_7.ForeColor = Color.Red; //Cores da Claro
            Btn_Valor_8.FlatAppearance.BorderColor = Color.Red; Btn_Valor_8.ForeColor = Color.Red; //Cores da Claro
            Txt_Operadora.Text = "Claro";
            Btn_Valor_1.Text = "12 reais"; Lbl_Validade_1.Text = "30 dias";  //Texto para o Txt de valor
            Btn_Valor_2.Text = "15 reais"; Lbl_Validade_2.Text = "30 dias";  //Texto para o Txt de valor
            Btn_Valor_3.Text = "20 reais"; Lbl_Validade_3.Text = "60 dias";  //Texto para o Txt de valor
            Btn_Valor_4.Text = "25 reais"; Lbl_Validade_4.Text = "60 dias";  //Texto para o Txt de valor
            Btn_Valor_5.Text = "30 reais"; Lbl_Validade_5.Text = "90 dias";  //Texto para o Txt de valor
            Btn_Valor_6.Text = "35 reais"; Lbl_Validade_6.Text = "90 dias";  //Texto para o Txt de valor
            Btn_Valor_7.Text = "50 reais"; Lbl_Validade_7.Text = "120 dias";  //Texto para o Txt de valor
            Btn_Valor_8.Text = "100 reais"; Lbl_Validade_8.Text = "180 dias";  //Texto para o Txt de valor
            Txt_Recarga.Text = ""; //Remover o texto
            Grp_Valores.Enabled = true; //Ativar o grp de valores
            Lbl_Valor_da_Recarga.ForeColor = Color.White;
            Lbl_Valor_da_Recarga.Enabled = false; //Desativando o lbl do valor da recarga
            Txt_Recarga.Enabled = false; //Desativando o Txt de valores
            Txt_Recarga.BackColor = Color.Gray; 
            Txt_Nome.Text = "Status da Recarga"; Txt_Nome.ForeColor = Color.Red;



        }

        private void Rad_Tim_CheckedChanged(object sender, EventArgs e)
        {
            Pc_Logo_de_Bob.Image = Properties.Resources.Cade_o_sinal_tim_removebg_preview;
            BackColor = Color.DarkBlue;
            Grp_Valores.BackColor = Color.DarkBlue;
            Grp_Operadoras.BackColor = Color.DarkBlue;
            Grp_Dados_da_Recarga.BackColor = Color.DarkBlue;
            Btn_Valor_1.FlatAppearance.BorderColor = Color.Blue; Btn_Valor_1.ForeColor = Color.Blue;
            Btn_Valor_2.FlatAppearance.BorderColor = Color.Blue; Btn_Valor_2.ForeColor = Color.Blue;
            Btn_Valor_3.FlatAppearance.BorderColor = Color.Blue; Btn_Valor_3.ForeColor = Color.Blue;
            Btn_Valor_4.FlatAppearance.BorderColor = Color.Blue; Btn_Valor_4.ForeColor = Color.Blue;
            Btn_Valor_5.FlatAppearance.BorderColor = Color.Blue; Btn_Valor_5.ForeColor = Color.Blue;
            Btn_Valor_6.FlatAppearance.BorderColor = Color.Blue; Btn_Valor_6.ForeColor = Color.Blue;
            Btn_Valor_7.FlatAppearance.BorderColor = Color.Blue; Btn_Valor_7.ForeColor = Color.Blue;
            Btn_Valor_8.FlatAppearance.BorderColor = Color.Blue; Btn_Valor_8.ForeColor = Color.Blue;
            Txt_Operadora.Text = "Tim";
            Btn_Valor_1.Text = "10 reais"; Lbl_Validade_1.Text = "30 dias";  //Texto para o Txt de valor
            Btn_Valor_2.Text = "15 reais"; Lbl_Validade_2.Text = "30 dias";  //Texto para o Txt de valor
            Btn_Valor_3.Text = "20 reais"; Lbl_Validade_3.Text = "30 dias";  //Texto para o Txt de valor
            Btn_Valor_4.Text = "30 reais"; Lbl_Validade_4.Text = "30 dias";  //Texto para o Txt de valor
            Btn_Valor_5.Text = "40 reais"; Lbl_Validade_5.Text = "90 dias";  //Texto para o Txt de valor
            Btn_Valor_6.Text = "50 reais"; Lbl_Validade_6.Text = "180 dias";  //Texto para o Txt de valor
            Btn_Valor_7.Text = "60 reais"; Lbl_Validade_7.Text = "180 dias";  //Texto para o Txt de valor
            Btn_Valor_8.Text = "100 reais"; Lbl_Validade_8.Text = "180 dias";  //Texto para o Txt de valor
            Txt_Recarga.Text = "";
            Grp_Valores.Enabled = true;
            Lbl_Valor_da_Recarga.ForeColor = Color.White;
            Lbl_Valor_da_Recarga.Enabled = false;
            Txt_Recarga.Enabled = false;
            Txt_Recarga.BackColor = Color.Gray;
            Txt_Nome.Text = "Status da Recarga"; Txt_Nome.ForeColor = Color.Blue;


        }

        private void Rad_Vivo_CheckedChanged(object sender, EventArgs e)
        {
            Pc_Logo_de_Bob.Image = Properties.Resources.Vivo_falhando_removebg_preview;
            BackColor = Color.Purple;
            Grp_Valores.Enabled = true;
            Grp_Valores.BackColor = Color.Purple;
            Grp_Operadoras.BackColor = Color.Purple;
            Grp_Dados_da_Recarga.BackColor = Color.Purple;
            Btn_Valor_1.FlatAppearance.BorderColor = Color.Violet; Btn_Valor_1.ForeColor = Color.Violet;
            Btn_Valor_2.FlatAppearance.BorderColor = Color.Violet; Btn_Valor_2.ForeColor = Color.Violet;
            Btn_Valor_3.FlatAppearance.BorderColor = Color.Violet; Btn_Valor_3.ForeColor = Color.Violet;
            Btn_Valor_4.FlatAppearance.BorderColor = Color.Violet; Btn_Valor_4.ForeColor = Color.Violet;
            Btn_Valor_5.FlatAppearance.BorderColor = Color.Violet; Btn_Valor_5.ForeColor = Color.Violet;
            Btn_Valor_6.FlatAppearance.BorderColor = Color.Violet; Btn_Valor_6.ForeColor = Color.Violet;
            Btn_Valor_7.FlatAppearance.BorderColor = Color.Violet; Btn_Valor_7.ForeColor = Color.Violet;
            Btn_Valor_8.FlatAppearance.BorderColor = Color.Violet; Btn_Valor_8.ForeColor = Color.Violet;
            Txt_Operadora.Text = "Vivo";
            Btn_Valor_1.Text = "12 reais"; Lbl_Validade_1.Text  = "30 dias";
            Btn_Valor_2.Text = "15 reais"; Lbl_Validade_2.Text = "30 dias";
            Btn_Valor_3.Text = "20 reais"; Lbl_Validade_3.Text = "30 dias";
            Btn_Valor_4.Text = "30 reais"; Lbl_Validade_4.Text = "30 dias";
            Btn_Valor_5.Text = "35 reais"; Lbl_Validade_5.Text = "90 dias";
            Btn_Valor_6.Text = "40 reais"; Lbl_Validade_6.Text = "90 dias";
            Btn_Valor_7.Text = "100 reais"; Lbl_Validade_7.Text = "180 dias";
            Btn_Valor_8.Text = "200 reais"; Lbl_Validade_8.Text = "365 dias";
            Grp_Valores.Enabled = true;
            Txt_Recarga.Text = "";
            Lbl_Valor_da_Recarga.ForeColor = Color.White;
            Lbl_Valor_da_Recarga.Enabled = false;
            Txt_Recarga.Enabled = false;
            Txt_Recarga.BackColor = Color.Gray;
            Txt_Nome.Text = "Status da Recarga"; Txt_Nome.ForeColor = Color.Violet;

        }

        private void Pc_Logo_de_Bob_Click(object sender, EventArgs e)
        {
           
        }

        private void Txt_Celular_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grp_Valores_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Msk_Celular.MaskCompleted) // Condição para caso o Textbox seja Preenchido
            {
            Txt_Recarga.Text = Btn_Valor_1.Text;  // Mudar ou colocar o texto no botão de valores
            Lbl_Valor_da_Recarga.Enabled = true; // Habilitar o Lbl
            Txt_Recarga.Enabled = true; // Habilitar o txt
            Txt_Recarga.BackColor = Color.White; // Mudar a cor de fundo
            Txt_Nome.Text = "Recarga feita com Sucesso!";

            }
            else //Caso o número não seja digitado por completo
            {
                MessageBox.Show("Digite um Número de Celular", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem de erro
                Msk_Celular.Focus(); // Posição do cursor no centro
            }
            
        }

        private void Btn_Valor_2_Click(object sender, EventArgs e)
        {
            if (Msk_Celular.MaskCompleted) // Condição para caso o Textbox seja Preenchido
            {
            Txt_Recarga.Text = Btn_Valor_2.Text;  // Mudar ou colocar o texto no botão de valores
            Lbl_Valor_da_Recarga.Enabled = true; // Habilitar o Lbl
            Txt_Recarga.Enabled = true; // Habilitar o txt
            Txt_Recarga.BackColor = Color.White; // Mudar a cor de fundo
            Txt_Nome.Text = "Recarga feita com Sucesso!";

            }
            else //Caso o número não seja digitado por completo
            {
                MessageBox.Show("Digite um Número de Celular", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem de erro
                Msk_Celular.Focus(); // Posição do cursor no centro
            }
        }

        private void Btn_Valor_3_Click(object sender, EventArgs e)
        {
            if (Msk_Celular.MaskCompleted) // Condição para caso o Textbox seja Preenchido
            {
            Txt_Recarga.Text = Btn_Valor_3.Text;  // Mudar ou colocar o texto no botão de valores
            Lbl_Valor_da_Recarga.Enabled = true; // Habilitar o Lbl
            Txt_Recarga.Enabled = true; // Habilitar o txt
            Txt_Recarga.BackColor = Color.White; // Mudar a cor de fundo
            Txt_Nome.Text = "Recarga feita com Sucesso!";

            }
            else //Caso o número não seja digitado por completo
            {
                MessageBox.Show("Digite um Número de Celular", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem de erro
                Msk_Celular.Focus(); // Posição do cursor no centro
            }
        }

        private void Btn_Valor_4_Click(object sender, EventArgs e)
        {
            if (Msk_Celular.MaskCompleted) // Condição para caso o Textbox seja Preenchido
            {
            Txt_Recarga.Text = Btn_Valor_4.Text;  // Mudar ou colocar o texto no botão de valores
            Lbl_Valor_da_Recarga.Enabled = true; // Habilitar o Lbl
            Txt_Recarga.Enabled = true; // Habilitar o txt
            Txt_Recarga.BackColor = Color.White; // Mudar a cor de fundo
            Txt_Nome.Text = "Recarga feita com Sucesso!"; //Mudar o Texto do Status

            }
            else //Caso o número não seja digitado por completo
            {
                MessageBox.Show("Digite um Número de Celular", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem de erro
                Msk_Celular.Focus(); // Posição do cursor no centro
            }
        }

        private void Btn_Valor_5_Click(object sender, EventArgs e)
        {
            if (Msk_Celular.MaskCompleted) // Condição para caso o Textbox seja Preenchido
            {
            Txt_Recarga.Text = Btn_Valor_5.Text;  // Mudar ou colocar o texto no botão de valores
            Lbl_Valor_da_Recarga.Enabled = true; // Habilitar o Lbl
            Txt_Recarga.Enabled = true; // Habilitar o txt
            Txt_Recarga.BackColor = Color.White; // Mudar a cor de fundo
            Txt_Nome.Text = "Recarga feita com Sucesso!"; //Mudar o Texto do Status

            }
            else //Caso o número não seja digitado por completo
            {
                MessageBox.Show("Digite um Número de Celular", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem de erro
                Msk_Celular.Focus(); // Posição do cursor no centro
            }
        }

        private void Btn_Valor_6_Click(object sender, EventArgs e)
        {
            if (Msk_Celular.MaskCompleted) // Condição para caso o Textbox seja Preenchido
            {
            Txt_Recarga.Text = Btn_Valor_6.Text;  // Mudar ou colocar o texto no botão de valores
            Lbl_Valor_da_Recarga.Enabled = true; // Habilitar o Lbl
            Txt_Recarga.Enabled = true; // Habilitar o txt
            Txt_Recarga.BackColor = Color.White; // Mudar a cor de fundo
            Txt_Nome.Text = "Recarga feita com Sucesso!"; //Mudar o Texto do Status

            }
            else //Caso o número não seja digitado por completo
            {
                MessageBox.Show("Digite um Número de Celular", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem de erro
                Msk_Celular.Focus(); // Posição do cursor no centro
            }
        }

        private void Btn_Valor_7_Click(object sender, EventArgs e)
        {
            if (Msk_Celular.MaskCompleted) // Condição para caso o Textbox seja Preenchido
            {
            Txt_Recarga.Text = Btn_Valor_7.Text; // Mudar ou colocar o texto no botão de valores
            Lbl_Valor_da_Recarga.Enabled = true; // Habilitar o Lbl
            Txt_Recarga.Enabled = true; // Habilitar o txt
            Txt_Recarga.BackColor = Color.White;// Mudar a cor de fundo
            Txt_Nome.Text = "Recarga feita com Sucesso!"; //Mudar o texto do status da recarga

            }
            else //Caso o número não seja digitado por completo
            {
                MessageBox.Show("Digite um Número de Celular", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem de erro
                Msk_Celular.Focus(); // Posição do cursor no centro
            }
        }

        private void Btn_Valor_8_Click(object sender, EventArgs e)
        {
            if (Msk_Celular.MaskCompleted) // Condição para caso o Textbox seja Preenchido
            {
            Txt_Recarga.Text = Btn_Valor_8.Text; // Mudar ou colocar o texto no botão de valores
            Lbl_Valor_da_Recarga.Enabled = true; // Habilitar o Lbl
            Txt_Recarga.Enabled = true; // Habilitar o txt
            Txt_Recarga.BackColor = Color.White; // Mudar a cor de fundo
            Txt_Nome.Text = "Recarga feita com Sucesso!"; //Mudar o texto do status da recarga

            }
            else //Caso o número não seja digitado por completo
            {
                MessageBox.Show("Digite um Número de Celular", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem de erro
                Msk_Celular.Focus(); // Posição do cursor no centro
            }
        }

        private void Lbl_Valor_da_Recarga_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Nome_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Região_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Operadora_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_DDD_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Finalizar_Click(object sender, EventArgs e)
        {
            if (Msk_Celular.MaskCompleted && Txt_Recarga .Text!="")
            {
            Frm_Menu menu = new Frm_Menu();
            menu.Show();
            Hide();

            }
            else
            {
                MessageBox.Show("Número de Celular não inserido ou Valor não Selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Frm_Valores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Fechar o Aplicativo
        }

        private void Msk_Celular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
          
        }
    }
}
