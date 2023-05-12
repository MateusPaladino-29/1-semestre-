
namespace Contato
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        public string CNPJ { get; set; }

        public bool ValidarCNPJ(string _cnpj)  
        {
            return _cnpj.Length == 11;
        }
    }
}