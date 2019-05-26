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
    public partial class cadForm : Form
    {
        public cadForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // CRIA (INSTANCIA) OBJETO COM CLASSE SISTEMA 
            SystemaControl Controll = new SystemaControl();


            // CRIA VARIAVEIS PARA TRATAMENTO DE DADOS ABAIXO
            var nome = inputNameProduto.Text;
            var quantidade = 0;
            var categoria = inputCategoria.Text;


            // CHECA OS CAMPOS PARA VERIFICAR SE EXISTE NULO
            if (nome == "" || inputQuantidade.Text == "" || categoria == "")
            {

                // MENSAGEM EM CASO DE CAMPO NULO
                MessageBox.Show("Favor preencher todos os campos", "Favor preencher todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // VERIFICA SE FOI INFORMADO INTEIRO NO CAMPO QUANTIDADE
                try
                {
                    quantidade = Convert.ToInt32(inputQuantidade.Text);
                }
                catch
                {
                    MessageBox.Show("Favor informar somente números no campo quantidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // CASO TENHA PASSADO PELO FILTRO, SALVA O PRODUTO
                Controll.saveData(new Produto(nome, categoria, quantidade, "--"));

                // LIMPA OS CAMPOS
                inputNameProduto.Text = "";
                inputQuantidade.Text = "";
                inputCategoria.Text = "";

                /// FEEDBACK DE SUCESSO
                MessageBox.Show("Produto cadastrado, sinta-se a vontade para cadastrar outro", "Produto cadastrado com a", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //
            }
        }

        private void CadForm_Load(object sender, EventArgs e)
        {

        }
    }
}
