using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contato
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();

        public void Adicionar(Contato _contato)
        {
            Agenda.add(Contato _contatos);
        }

        public void Listar()
        {
            Agenda.add(Listar);
        }

        private static void add(Action listar)
        {
          
        }
    }
}


Console.Clear();
Console.WriteLine($"Quantidade de contatos: {Agenda.Count}");


