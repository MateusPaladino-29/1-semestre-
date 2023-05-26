


namespace Produto_mvc.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        //caminho da pasta e do arquivo csv
        private const string PATH = "Database/Produto.csv";
        public Produto()
        {
            //criar a lógica para gerar a pasta e o arquivo
            // obter o caminho da pasta 
            string pasta = PATH.Split("/")[0];

            //verificar se no caminho ja existe uma pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //verificar se no caminho ja existe um arquivo
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }


        // leituras das linhas 
        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();


            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                // separacao sw atribustos por cada linha
                string[] atributos = item.Split(";");

                // instancia do produto
                Produto p = new Produto();

                // atribuiçao de valores dentro do objeto

                p.Codigo = int.Parse(atributos[0]);

                p.Nome = atributos[1];

                p.Preco = float.Parse(atributos[2]);


                // adiciona objeto de produto 
                produtos.Add(p);
            }

            // retorna a lista de produtos 
            return produtos;
        }

        // metodo para preparar as linhas a serem inseridas no csv
        public string PrepararLinhaCSV(Produto p)
        {

            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        // metodo para inserir um produto na linha do csv

        public void Inserir(Produto p)
        {
            string[] linhas = { PrepararLinhaCSV(p) };

            File.AppendAllLines(PATH, linhas);
        }

            
    }
}
