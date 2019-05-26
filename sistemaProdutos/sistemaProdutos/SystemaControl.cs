using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sistemaProdutos
{
    public class SystemaControl
    {

        // ESTA CLASSE FACILITA MANIPULACAO DE DADOS, COM INTUITO DE SER O SISTEMA PRINCIPAL
        // COM A IDEIA DE QUE TUDO QUE SEJA FEITO POR PARTE DO SISTEMA SEJA FEITO AQUI



        // METODO FEITO PARA EXCLUSAO DE UM PRODUTO
        public void deleteData(Produto p, bool msg)
        {

            // OBJETO INSTANCIADO DA BASE QUE CONTEM O METODO DE EXCLUSAO
            System.IO.FileInfo fi = new System.IO.FileInfo(p.NomeArquvio + ".xml");
            try
            {

                //DELETA DE ACORDO COM O NOME DO ARQUIVO QUE É PASSADO ACIMA
                fi.Delete();
            }
            catch
            {
                if (msg == true)
                {
                    MessageBox.Show("Poduto deletado com sucesso", "Feito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        // CLASSE RESPONSAVEL POR CRIAR O PRODUTO E SALVAR O ARQUIVO XML
        public void saveData(Produto ProdutoIn)
        {

            var produto = new[] { ProdutoIn };
            var xml = new XDocument(new XElement(ProdutoIn.NomeArquvio,
                                                produto.Select(prod => new XElement("Produto",
                                                    new XAttribute("nome", prod.Nome),
                                                    new XAttribute("quantidade", prod.Quantidade),
                                                    new XAttribute("categoria", prod.Categoria),
                                                    new XAttribute("historico", prod.Historico)))));

            xml.Save(ProdutoIn.NomeArquvio + ".xml");

        }




        // METODO RESPONSAVEL POR BUSCAR O ARQUIVO QUE CONTEM O PROTUDO SOLICITADO 
        // SENDO NECESSARIO PASSAR SOMENTE UM OBJETO DO TIPO PRODUTO
        public Produto getData(Produto prodIn)
        {

            // SETA COMO PADRAO UM PRODUTO NAO ENCONTRADO
            Produto rResturn = new Produto("Não encontrado", "Não encontrado", 0, "--");

            try
            {

                // BUSCA O XML CORRESPONDENDO VERIFICANDO SE O ARQUIVO EXISTE
                var xml = XDocument.Load(prodIn.NomeArquvio + ".xml");

                Produto[] produtoGetXml = xml.Element(prodIn.NomeArquvio).Elements("Produto")
                                   .Select(x => new Produto(x.Attribute("nome").Value,
                                                           x.Attribute("categoria").Value,
                                                           int.Parse(x.Attribute("quantidade").Value),
                                                           x.Attribute("historico").Value)).ToArray();
                // CASO O ARQUIVO EXISTA ESTE SERA INSERIDO NA VARIAVEL QUE IRA RETORNAR
                rResturn = produtoGetXml[0];
            }
            catch
            {
                // CATCH SOMENTE PARA QUE SEJA USADO O TRY PARA QUE NAO SEJA CRASHADO O SISTEMA
            }

            // RETORNA DE ACORDO COM SELECIONADO
            return rResturn;
        }


        // CLASSE QUE REMOVE QUANTIDADES DO PRODUTO EM ESTOQUE
        public void Remove(Produto p, int qGet)
        {

            // OBJETO DO SISTEMA CONTROLE PARA QUE SEJA USADO SEUS METODOS
            SystemaControl cc = new SystemaControl();

            // VERIFICA SE É POSSIVEL EXCLUIR DO SISTEMA SEM QUE ATINJA VALOR MINIMO PERMITIDO EM ESTOQUE
            if (p.checkQuantidade(qGet))
            {
                p.Quantidade -= qGet;
                p.setHist("Quantidade retirada de: " + qGet + " As " + DateTime.Now + " - \n");
                cc.saveData(p);
                MessageBox.Show("Produto retirado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nao e possivel retirar esta quantidade pois o produto ficara abaixo do estoque permitido", "Acao nao autorizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}