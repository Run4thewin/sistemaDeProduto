using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadForm n = new cadForm();
            n.Show();
        }

        private void SairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BuscarEditarDeletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscaProduto bProdutoTela = new buscaProduto();
            bProdutoTela.Show();
        }
    }
}
