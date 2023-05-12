using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contato
{
    public interface IContatoPessoal 
    {
        public bool ValidarCPF(string _cpf);
                 
    }
}