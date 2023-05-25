
namespace mvc_cadastro.Model
{
    public class Evento
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime Data { get; set; }

        private const string PATH = "Database/evento.csv";

        public Evento()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }


        }

        public List<Evento> ler()
        {
            List<Evento> evento = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Evento e = new Evento();

                e.Nome = atributos[0];
                e.Descricao = atributos[1];
                e.Data = DateTime.Parse(atributos[2]);

                evento.Add(e);

            }

            return evento;
        }

        public string PrepararLinhas(Evento e)
        {
            return $"{e.Nome}; {e.Descricao}; {e.Data}";
        }

        public void InserirEvento(Evento e)
        {
            string[] linhas = {PrepararLinhas(e)};

            File.AppendAllLines(PATH, linhas);
        }
    }
}