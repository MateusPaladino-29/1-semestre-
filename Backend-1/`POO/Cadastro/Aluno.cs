
// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.


namespace cadastro
{
    public class Aluno
    {
        public string Nome;
        public string Curso;
        public int Idade;
        public string RG;
        public bool bolsista;
        public float MediaFinal;
        public float ValorMensalidade;
        public int Valor = 0;
        public float Desconto = 0;

        public void VerMediaFinal()
        {
            Console.WriteLine($"Sua media final:{MediaFinal}");

        }

        public float VerMensalidade()
        {

            
                    if (bolsista == true && MediaFinal >= 8)
                    {
                        Desconto = ValorMensalidade * 0.05f;

                    }

                    else if (bolsista == true && MediaFinal >= 6 || MediaFinal <= 8)

                    {
                        Desconto = ValorMensalidade * 0.03f;
                    }

                    else
                    {
                        Console.WriteLine($"Outro valor ");

                    }
                  
                        return this.ValorMensalidade;

                
            }

      

        }

    }