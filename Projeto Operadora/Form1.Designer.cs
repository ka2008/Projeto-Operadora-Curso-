
namespace Projeto_Operadora
{
    partial class Frm_Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Grp_Dados = new System.Windows.Forms.GroupBox();
            this.Lbl_DDD = new System.Windows.Forms.Label();
            this.Txt_DDD = new System.Windows.Forms.TextBox();
            this.Txt_Região_Selecionada = new System.Windows.Forms.TextBox();
            this.Lbl_Região_Selecionada = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Pc_Logo_de_Bob = new System.Windows.Forms.PictureBox();
            this.Grp_Regiões = new System.Windows.Forms.GroupBox();
            this.Rad_e = new System.Windows.Forms.RadioButton();
            this.Pc_Bob_Dancando = new System.Windows.Forms.PictureBox();
            this.Rad_São_Paulo = new System.Windows.Forms.RadioButton();
            this.Rad_Rio = new System.Windows.Forms.RadioButton();
            this.Rad_Minas_Gerais = new System.Windows.Forms.RadioButton();
            this.Rad_Espirito_Santo = new System.Windows.Forms.RadioButton();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.Grp_Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pc_Logo_de_Bob)).BeginInit();
            this.Grp_Regiões.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pc_Bob_Dancando)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_Dados
            // 
            this.Grp_Dados.BackColor = System.Drawing.Color.Black;
            this.Grp_Dados.Controls.Add(this.Lbl_DDD);
            this.Grp_Dados.Controls.Add(this.Txt_DDD);
            this.Grp_Dados.Controls.Add(this.Txt_Região_Selecionada);
            this.Grp_Dados.Controls.Add(this.Lbl_Região_Selecionada);
            this.Grp_Dados.Controls.Add(this.Txt_Nome);
            this.Grp_Dados.Controls.Add(this.Lbl_Nome);
            this.Grp_Dados.Controls.Add(this.Pc_Logo_de_Bob);
            this.Grp_Dados.Controls.Add(this.Grp_Regiões);
            this.Grp_Dados.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Dados.ForeColor = System.Drawing.Color.White;
            this.Grp_Dados.Location = new System.Drawing.Point(12, 12);
            this.Grp_Dados.Name = "Grp_Dados";
            this.Grp_Dados.Size = new System.Drawing.Size(776, 385);
            this.Grp_Dados.TabIndex = 0;
            this.Grp_Dados.TabStop = false;
            this.Grp_Dados.Text = "Dados da Recarga";
            this.Grp_Dados.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Lbl_DDD
            // 
            this.Lbl_DDD.AutoSize = true;
            this.Lbl_DDD.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DDD.Location = new System.Drawing.Point(658, 319);
            this.Lbl_DDD.Name = "Lbl_DDD";
            this.Lbl_DDD.Size = new System.Drawing.Size(46, 23);
            this.Lbl_DDD.TabIndex = 7;
            this.Lbl_DDD.Text = "DDD";
            // 
            // Txt_DDD
            // 
            this.Txt_DDD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DDD.Location = new System.Drawing.Point(710, 321);
            this.Txt_DDD.Name = "Txt_DDD";
            this.Txt_DDD.ReadOnly = true;
            this.Txt_DDD.Size = new System.Drawing.Size(45, 22);
            this.Txt_DDD.TabIndex = 6;
            // 
            // Txt_Região_Selecionada
            // 
            this.Txt_Região_Selecionada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Região_Selecionada.Location = new System.Drawing.Point(504, 320);
            this.Txt_Região_Selecionada.Name = "Txt_Região_Selecionada";
            this.Txt_Região_Selecionada.ReadOnly = true;
            this.Txt_Região_Selecionada.Size = new System.Drawing.Size(150, 22);
            this.Txt_Região_Selecionada.TabIndex = 5;
            // 
            // Lbl_Região_Selecionada
            // 
            this.Lbl_Região_Selecionada.AutoSize = true;
            this.Lbl_Região_Selecionada.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Região_Selecionada.Location = new System.Drawing.Point(345, 318);
            this.Lbl_Região_Selecionada.Name = "Lbl_Região_Selecionada";
            this.Lbl_Região_Selecionada.Size = new System.Drawing.Size(154, 23);
            this.Lbl_Região_Selecionada.TabIndex = 4;
            this.Lbl_Região_Selecionada.Text = "Região Selecionada";
            this.Lbl_Região_Selecionada.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(31, 70);
            this.Txt_Nome.MaxLength = 50;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(296, 22);
            this.Txt_Nome.TabIndex = 3;
            this.Txt_Nome.TextChanged += new System.EventHandler(this.Txt_Nome_TextChanged);
            this.Txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nome_KeyPress);
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.Location = new System.Drawing.Point(27, 44);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(52, 23);
            this.Lbl_Nome.TabIndex = 2;
            this.Lbl_Nome.Text = "Nome";
            this.Lbl_Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pc_Logo_de_Bob
            // 
            this.Pc_Logo_de_Bob.Image = global::Projeto_Operadora.Properties.Resources.spongebob_swag_removebg_preview;
            this.Pc_Logo_de_Bob.Location = new System.Drawing.Point(31, 98);
            this.Pc_Logo_de_Bob.Name = "Pc_Logo_de_Bob";
            this.Pc_Logo_de_Bob.Size = new System.Drawing.Size(296, 250);
            this.Pc_Logo_de_Bob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pc_Logo_de_Bob.TabIndex = 1;
            this.Pc_Logo_de_Bob.TabStop = false;
            this.Pc_Logo_de_Bob.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Grp_Regiões
            // 
            this.Grp_Regiões.BackColor = System.Drawing.Color.Black;
            this.Grp_Regiões.Controls.Add(this.Pc_Bob_Dancando);
            this.Grp_Regiões.Controls.Add(this.Rad_São_Paulo);
            this.Grp_Regiões.Controls.Add(this.Rad_Rio);
            this.Grp_Regiões.Controls.Add(this.Rad_Minas_Gerais);
            this.Grp_Regiões.Controls.Add(this.Rad_Espirito_Santo);
            this.Grp_Regiões.Enabled = false;
            this.Grp_Regiões.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_Regiões.ForeColor = System.Drawing.Color.White;
            this.Grp_Regiões.Location = new System.Drawing.Point(349, 33);
            this.Grp_Regiões.Name = "Grp_Regiões";
            this.Grp_Regiões.Size = new System.Drawing.Size(421, 239);
            this.Grp_Regiões.TabIndex = 0;
            this.Grp_Regiões.TabStop = false;
            this.Grp_Regiões.Text = "Região Sudeste";
            this.Grp_Regiões.Visible = false;
            this.Grp_Regiões.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Rad_e
            // 
            this.Rad_e.AutoSize = true;
            this.Rad_e.Cursor = System.Windows.Forms.Cursors.No;
            this.Rad_e.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_e.ForeColor = System.Drawing.Color.White;
            this.Rad_e.Location = new System.Drawing.Point(825, 436);
            this.Rad_e.Name = "Rad_e";
            this.Rad_e.Size = new System.Drawing.Size(61, 25);
            this.Rad_e.TabIndex = 5;
            this.Rad_e.TabStop = true;
            this.Rad_e.Text = "Sans";
            this.Rad_e.UseVisualStyleBackColor = true;
            this.Rad_e.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // Pc_Bob_Dancando
            // 
            this.Pc_Bob_Dancando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pc_Bob_Dancando.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pc_Bob_Dancando.Image = global::Projeto_Operadora.Properties.Resources.spongebob_dancing;
            this.Pc_Bob_Dancando.Location = new System.Drawing.Point(24, 37);
            this.Pc_Bob_Dancando.Name = "Pc_Bob_Dancando";
            this.Pc_Bob_Dancando.Size = new System.Drawing.Size(218, 177);
            this.Pc_Bob_Dancando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pc_Bob_Dancando.TabIndex = 4;
            this.Pc_Bob_Dancando.TabStop = false;
            this.Pc_Bob_Dancando.Click += new System.EventHandler(this.Pc_Bob_Dancando_Click);
            // 
            // Rad_São_Paulo
            // 
            this.Rad_São_Paulo.AutoSize = true;
            this.Rad_São_Paulo.Cursor = System.Windows.Forms.Cursors.No;
            this.Rad_São_Paulo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_São_Paulo.Location = new System.Drawing.Point(260, 166);
            this.Rad_São_Paulo.Name = "Rad_São_Paulo";
            this.Rad_São_Paulo.Size = new System.Drawing.Size(97, 25);
            this.Rad_São_Paulo.TabIndex = 3;
            this.Rad_São_Paulo.TabStop = true;
            this.Rad_São_Paulo.Text = "São Paulo";
            this.Rad_São_Paulo.UseVisualStyleBackColor = true;
            this.Rad_São_Paulo.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Rad_Rio
            // 
            this.Rad_Rio.AutoSize = true;
            this.Rad_Rio.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Rio.Location = new System.Drawing.Point(260, 129);
            this.Rad_Rio.Name = "Rad_Rio";
            this.Rad_Rio.Size = new System.Drawing.Size(134, 25);
            this.Rad_Rio.TabIndex = 2;
            this.Rad_Rio.TabStop = true;
            this.Rad_Rio.Text = "Rio de Janeiro";
            this.Rad_Rio.UseVisualStyleBackColor = true;
            this.Rad_Rio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Rad_Minas_Gerais
            // 
            this.Rad_Minas_Gerais.AutoSize = true;
            this.Rad_Minas_Gerais.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Minas_Gerais.Location = new System.Drawing.Point(260, 92);
            this.Rad_Minas_Gerais.Name = "Rad_Minas_Gerais";
            this.Rad_Minas_Gerais.Size = new System.Drawing.Size(119, 25);
            this.Rad_Minas_Gerais.TabIndex = 1;
            this.Rad_Minas_Gerais.TabStop = true;
            this.Rad_Minas_Gerais.Text = "Minas Gerais";
            this.Rad_Minas_Gerais.UseVisualStyleBackColor = true;
            this.Rad_Minas_Gerais.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Rad_Espirito_Santo
            // 
            this.Rad_Espirito_Santo.AutoSize = true;
            this.Rad_Espirito_Santo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Espirito_Santo.Location = new System.Drawing.Point(260, 55);
            this.Rad_Espirito_Santo.Name = "Rad_Espirito_Santo";
            this.Rad_Espirito_Santo.Size = new System.Drawing.Size(130, 25);
            this.Rad_Espirito_Santo.TabIndex = 0;
            this.Rad_Espirito_Santo.TabStop = true;
            this.Rad_Espirito_Santo.Text = "Espírito Santo";
            this.Rad_Espirito_Santo.UseVisualStyleBackColor = true;
            this.Rad_Espirito_Santo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(692, 419);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirmar.TabIndex = 0;
            this.Btn_Confirmar.Text = "Confirmar";
            this.Btn_Confirmar.UseVisualStyleBackColor = true;
            this.Btn_Confirmar.Visible = false;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(811, 454);
            this.Controls.Add(this.Rad_e);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.Grp_Dados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eu sabo muito";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Menu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Grp_Dados.ResumeLayout(false);
            this.Grp_Dados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pc_Logo_de_Bob)).EndInit();
            this.Grp_Regiões.ResumeLayout(false);
            this.Grp_Regiões.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pc_Bob_Dancando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_Dados;
        private System.Windows.Forms.GroupBox Grp_Regiões;
        private System.Windows.Forms.PictureBox Pc_Logo_de_Bob;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.RadioButton Rad_São_Paulo;
        private System.Windows.Forms.RadioButton Rad_Rio;
        private System.Windows.Forms.RadioButton Rad_Minas_Gerais;
        private System.Windows.Forms.RadioButton Rad_Espirito_Santo;
        private System.Windows.Forms.Label Lbl_Região_Selecionada;
        private System.Windows.Forms.Label Lbl_DDD;
        private System.Windows.Forms.TextBox Txt_DDD;
        private System.Windows.Forms.TextBox Txt_Região_Selecionada;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.PictureBox Pc_Bob_Dancando;
        private System.Windows.Forms.RadioButton Rad_e;
    }
}

