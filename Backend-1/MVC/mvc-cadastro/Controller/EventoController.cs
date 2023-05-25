using mvc_cadastro.Model;
using mvc_cadastro.View;


namespace mvc_cadastro.Controller
{
    public class EventoController
    {
        
        Evento evento = new Evento();

        EventoView eventoview  = new EventoView();

        public void ListarEvento()
        {
            List<Evento> eventos = evento.ler();

            eventoview.Listar(eventos);
        }

        public void CadastrarEVento()
        {
            Evento eventinho = eventoview.Cadastrar();

            evento.InserirEvento(eventinho);
        }

        }
    }
