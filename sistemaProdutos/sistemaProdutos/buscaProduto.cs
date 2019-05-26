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
    public partial class buscaProduto : Form
    {
        public buscaProduto()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            // CRIA OBETO SISTEMA PARA FACILITAR TRATAMENTO DE DADOS
            SystemaControl c = new SystemaControl();

            // DELETA DE ACORDO COM NOME
            c.deleteData(new Produto(inputSearch.Text, "", 1, "--"), true);

            // FEEDBACK DA EXCLUSAO
            MessageBox.Show("Produto deletado com sucesso", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // CRIA A CLASSE SISTEMA PARA SystemaControl PARA FACILITAR O TRABALHO
            SystemaControl Controll = new SystemaControl();

            // BUSCA O PRODUTO DE ACORDO COM O NOME E GERA UM OBJETO PARA SER TRABALHADO
            Produto p = Controll.getData(new Produto(inputSearch.Text, "", 1, "--"));
            outPutName.Text = p.Nome;
            outPutCategoria.Text = p.Categoria;
            uotPutQuantidade.Text = p.Quantidade.ToString();
            historicoProd.Text = p.Historico;

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            // CRIA OBJETO PARA TRATAMENTO DE DADOS
            SystemaControl Controll = new SystemaControl();


            // RECEBE DADOS PARA TRATAMENTO
            var nome = outPutName.Text;
            var quantidade = 0;
            var categoria = outPutCategoria.Text;


            // VERIFICA SE ALGUM CAMPO ESTA NULO
            if (nome == "" || uotPutQuantidade.Text == "" || categoria == "" || nome == "Não encontrado")
            {

                MessageBox.Show("Favor preencher todos os campos", "Favor preencher todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // VERIFICA SE O CAMPO QUANTIDADE É INTEIRO
                try
                {
                    quantidade = Convert.ToInt32(uotPutQuantidade.Text);
                }
                catch
                {
                    MessageBox.Show("Favor informar somente números no campo quantidade", "Erro", MessageBoxButtons.OK);
                    return;
                }

                // RECEBE OS DADOS DA INPUT E SALVA NO XML
                Controll.saveData(new Produto(outPutName.Text, outPutCategoria.Text, Convert.ToInt32(uotPutQuantidade.Text), "--"));
                if (outPutName.Text != inputSearch.Text)
                {
                    Controll.deleteData(new Produto(inputSearch.Text, "", 1, "--"), true);
                }

                /// FEEDBACK DE SUCESSO
                MessageBox.Show("Produto Atualizado com sucesso", "Produto Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //
            }

        }

        private void BuscaProduto_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void UotPutQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void InputSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutPutName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Historico_Click(object sender, EventArgs e)
        {

        }

        private void HistoricoProd_Click(object sender, EventArgs e)
        {

        }

        private void OutPutCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Retirar_Click(object sender, EventArgs e)
        {
            // CRIA OBETJO PARA FACILITAR O TRATAMENTO
            SystemaControl Controll = new SystemaControl();

            // REMOVE DE ACORDO COM OS DADOS PASSADOS
            if (outPutCategoria.Text == "" || outPutName.Text == "" || uotPutQuantidade.Text == "" || removeFromStock.Text == "")
            {
                MessageBox.Show("Favor preencher todos os campos", "Erro ao excluir", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    Controll.Remove(new Produto(outPutName.Text, outPutCategoria.Text, Convert.ToInt32(uotPutQuantidade.Text), "--"), Convert.ToInt32(removeFromStock.Text));
                }
                catch
                {
                    MessageBox.Show("Favor informar somente números no campo quantidade", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }

        }
    }
}
