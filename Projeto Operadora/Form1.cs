using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Operadora
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Região_Selecionada.Text = Rad_Espirito_Santo.Text; Txt_DDD.Text = "27"; //Selecionar a Região Espirito Santo
            Pc_Bob_Dancando.Image = Properties.Resources.wojak;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Região_Selecionada.Text = Rad_Rio.Text; Txt_DDD.Text = "21"; //Selecionar a Região Rio de Janeiro
            Pc_Bob_Dancando.Image = Properties.Resources.bluezao;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Região_Selecionada.Text = Rad_Minas_Gerais.Text; Txt_DDD.Text  = "31"; //Selecionar a Região Minas Gerais
            Pc_Bob_Dancando.Image = Properties.Resources.minas;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Região_Selecionada.Text = Rad_São_Paulo.Text; Txt_DDD.Text  = "11"; //Selecionar a Região São Paulo
            Pc_Bob_Dancando.Image = Properties.Resources.fran;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pc_Bob_Dancando_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            
            if (Rad_Espirito_Santo.Checked || Rad_São_Paulo.Checked || Rad_Rio.Checked || Rad_Minas_Gerais.Checked)
            {
                Properties.Frm_Valores valores = new Properties.Frm_Valores();
                valores.Txt_Região.Text = Txt_Região_Selecionada.Text;
                valores.Txt_DDD.Text = Txt_DDD.Text;
                valores.Lbl_Nome.Text = Txt_Nome.Text;
                valores.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Selecione um dos Estados da região Sudeste", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                

            
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Pc_Bob_Dancando.Image = Properties.Resources.sanes;
            Txt_Região_Selecionada.Text = "E E E E E E E E E E E E"; Txt_DDD.Text = "E E E E E E E E E E ";
            MessageBox.Show("⁠Meu nome é Yoshikage Kira. Tenho 33 anos. Minha casa fica na parte nordeste de Morioh, onde todas as casas estão, e eu não sou casado. Eu trabalho como funcionário das lojas de departamentos Kame Yu e chego em casa todos os dias às oito da noite, no máximo. Eu não fumo, mas ocasionalmente bebo. Estou na cama às 23 horas e me certifico de ter oito horas de sono, não importa o que aconteça. Depois de tomar um copo de leite morno e fazer cerca de vinte minutos de alongamentos antes de ir para a cama, geralmente não tenho problemas para dormir até de manhã. Assim como um bebê, eu acordo sem nenhum cansaço ou estresse pela manhã. Foi-me dito que não houve problemas no meu último check-up. Estou tentando explicar que sou uma pessoa que deseja viver uma vida muito tranquila. Eu cuido para não me incomodar com inimigos, como ganhar e perder, isso me faria perder o sono à noite. É assim que eu lido com a sociedade e sei que é isso que me traz felicidade. Embora, se eu fosse lutar, não perderia para ninguém.", "Olá", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Frm_virus virus = new Frm_virus();
            virus.Show();
            Hide();
        }

        private void Frm_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Nome_TextChanged(object sender, EventArgs e)
        {
            
            if (Txt_Nome.Text != "")
            {
                Grp_Regiões.Visible = true;
                Grp_Regiões.Enabled = true;
                Btn_Confirmar.Visible = true;
            }
            else
            {
                Grp_Regiões.Visible = false;
                Grp_Regiões.Enabled = false;
                Btn_Confirmar.Visible = false;
                Rad_e.Checked = false;
                Rad_Espirito_Santo.Checked = false;
                Rad_Minas_Gerais.Checked = false;
                Rad_Rio.Checked = false;
                Rad_São_Paulo.Checked  = false;
                Pc_Bob_Dancando.Image = Properties.Resources.spongebob_dancing;
            }
        }

        private void Txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && char.IsControl(e.KeyChar) && char.IsSeparator(e.KeyChar)) //Condição pra digitar somente letras e permitir os controles
            {
                e.Handled = true; //Verificando se a condição foi obedecida
                MessageBox.Show("Digite somente letras", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mostrando a mensagem de aviso de erro na tela
            }
            if (e.KeyChar == 13) //Condição para verificar se o Enter foi pressionado
            {
                if (Txt_Nome.Text == "")  //Condição para verificar se nada foi digitado
                {
                    MessageBox.Show("Digite seu nome.", "ATENÇÃO: Cadê o nome????", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mostrando Mensagem de Erro
                }
                else //Condição para verificar se algo foi digitado
                {
                    Btn_Confirmar.Visible = true;
                    Grp_Regiões.Enabled = true;
                    Grp_Regiões.Visible = true;
                    
                }
            }
        }
    }
}
