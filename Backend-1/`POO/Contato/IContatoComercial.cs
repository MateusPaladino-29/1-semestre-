using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contato
{
    public interface IContatoComercial 
    {
        public bool ValidarCNPJ(string _cnpj);
    }
}