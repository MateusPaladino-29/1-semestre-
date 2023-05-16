
// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:
// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
// Subir : para subir um andar (não deve subir se já estiver no último andar);
// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).


namespace projetinho
{
    public class Elevador
    {
        public int Terreo { get; set; } = 0;
        public int TotalDeAndares { get; set; }
        public int Capacidade { get; set; }
        public int Quantidade { get; set; }

        // public string Acrescentar { get; set; } =  "sim";




        public void Inicializa(int capacidade, int totalDeAndares)
        {
            this.Capacidade = capacidade;
            this.TotalDeAndares = totalDeAndares;

            Console.WriteLine($"A capacidade de pessoas que cabem no elevador é de:{capacidade}");

            Console.WriteLine($"A quantidade de andares sáo de {totalDeAndares}");

        }

        public void Entrar()
        {

        Entrada:

            Console.WriteLine($"Quantas pessoas estao no elevador?");
            this.Quantidade = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Deseja acrescentar alguem? s/n");
            char opcao = char.Parse(Console.ReadLine()!.ToLower());

            switch (opcao)
            {
                case 's':



                    if (this.Quantidade < this.Capacidade)
                    {
                        Quantidade++;

                        Console.WriteLine($"Quantidade de passageiros:{this.Quantidade}");
                    }

                    else
                    {
                        Console.WriteLine($"ESta cheio, Nao entra mais ninguem");
                    }
                    break;

                case 'n':

                    Console.WriteLine($"Continuar viagem");
                    break;
                default:

                    Console.WriteLine($"Tente novamente");
                    goto Entrada;

                    break;
            }



        }

        public void Saida()

        {

           

            Console.WriteLine($"Quantidade de pessoa no elavador: {Quantidade}");


            Console.WriteLine($"Deseja sair do elevador? s/n");
            char Saida = char.Parse(Console.ReadLine()!.ToUpper());

            switch (Saida)
            {
                case 's':

                    Quantidade--;

                    Console.WriteLine($"Saindo do elevador: {Quantidade}");


                    break;

                case 'n':

                    Console.WriteLine($"Certo, proseguir viagem com {Quantidade}");

                    break;

                default:
                    break;
            }
        }

           public void Subir( int TotalDeAndares)
            
           {

            subindo:
                Console.WriteLine($"Informe para qual andar deseja subir"); 
                int subir = int.Parse(Console.ReadLine()!);

                switch (subir)
                {
                    case 1:
                    Console.WriteLine($"Subindo para o 1º "); 
                        break;

                         case 2:
                    Console.WriteLine($"Subindo para o 2º "); 
                        break;

                         case 3:
                    Console.WriteLine($"Subindo para o 3º "); 
                        break;

                         case 4:
                    Console.WriteLine($"Subindo para o 4º "); 
                        break;

                         case 5:
                    Console.WriteLine($"Subindo para o 5º "); 
                        break;

                         case 6:
                    Console.WriteLine($"Subindo para o 6º "); 
                        break;

                         case 7:
                    Console.WriteLine($"Subindo para o 7º "); 
                        break;

                    default:

                    Console.WriteLine($"Não temos esse andar");
                    goto subindo;
                        break;
                }
                                
           }

            public void Descer( int TotalDeAndares)
            
           {

            descer:
                Console.WriteLine($"Informe para qual andar deseja descer"); 
                int descer = int.Parse(Console.ReadLine()!);

                switch (descer)
                {
                    case 6:
                    Console.WriteLine($"Descendo para o 6º "); 
                        break;

                         case 5:
                    Console.WriteLine($"Descendo para o 5º "); 
                        break;

                         case 4:
                    Console.WriteLine($"Descendo para o 4º "); 
                        break;

                         case 3:
                    Console.WriteLine($"Descendo para o 3º "); 
                        break;

                         case 2:
                    Console.WriteLine($"descendo ara o 2º "); 
                        break;

                         case 1:
                    Console.WriteLine($"Descendo para o 1º "); 
                        break;

                         case 0:
                    Console.WriteLine($"Descendo para o terro "); 
                        break;

                    default:

                    Console.WriteLine($"Não temos esse andar");
                    goto descer;
                        break;
                }
                                
           }
    }
}

