// Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)

namespace Moeda
{
    public static class Cambio
    {

        // Propriedade

        public static float Valor { get; set; }
        
        
        // public static float Dolar; 

        // metodo

        public static float RealToDolar(float real)
        {
             Valor = real;

            float dolar = (real * 5);

            return dolar;

        }

        public static float DolarToReal(float dolar)
        {
            Valor = dolar;

            float real = (dolar * 0.20f);

            return real;

        }

        // internal static float DolarToReal()
        // {
        //     throw new NotImplementedException();
        // }

        // internal static float RealToDolar()
        // {
        //     throw new NotImplementedException();
        // }
    }
}