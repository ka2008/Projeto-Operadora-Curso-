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
    public partial class Frm_virus : Form
    {
        public Frm_virus()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://jcw87.github.io/c2-sans-fight/");
            webBrowser1.Visible = true;
        }

        private void virus_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_virus virus = new Frm_virus();
            virus.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Frm_virus_Load(object sender, EventArgs e)
        {
            
        }
    }
}
