
namespace Contato
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string CPF { get; set; }

        public bool ValidarCPF(string _cpf) 
        {
            return _cpf.Length == 11;
        }
    }
}