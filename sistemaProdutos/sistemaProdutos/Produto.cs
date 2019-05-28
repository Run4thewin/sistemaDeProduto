namespace sistemaProdutos
{
    public class Produto
    {
        // GETS AND SETERS
        public string Nome { get; private set; }
        public string Categoria { get; private set; }
        public int Quantidade { get; internal set; }
        public string NomeArquvio { get; private set; }
        public string Historico { get; internal set; }

        public int quantidadePermitida = 1;

        // TODO PRODUTO DEVE SER INICIADO COM NOME, CATEGORIA E QUANTIDADE E UM HISTORICO 

        //METODO CONSTRUTOR
        public Produto(string nomeProduto, string Categoria, int Quantidade, string historico)
        {
            this.Nome = nomeProduto;
            this.Categoria = Categoria;
            this.Quantidade = Quantidade;
            this.NomeArquvio = nomeProduto.Replace(" ", "_");
            this.Historico = historico;
        }


        // COMANDO PARA ADICIONAR PRODUTOS NO ESTOQUE
        public void add(Produto p, int qAdd)
        {
            p.Quantidade += qAdd;
        }

        // CHECA SE O PRODUTO PODE SER RETIRADO SEM QUE ATEINJA A QUANTIDADE MINIMA
        public bool checkQuantidade(int q)
        {
            if (q > this.Quantidade - this.quantidadePermitida)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        // ADICIONA DADOS AO HISTORICO DO PRODUTO PARA SABER SOBRE ULTIMAS MUDANÇAS POR EXEMPLO
        public void setHist(string s)
        {
            this.Historico += s;
        }


    }
}
