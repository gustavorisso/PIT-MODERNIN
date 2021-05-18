using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraRemedio
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void botaoConectar_Click(object sender, EventArgs e)
        {
            
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FormCadastrar cadastrar = new FormCadastrar();
            this.Hide();
            cadastrar.ShowDialog();
            this.Close();
        }
    }
}
