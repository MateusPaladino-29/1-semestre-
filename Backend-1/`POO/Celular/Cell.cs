// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

namespace celular
{
    public class cells
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool Ligado;


        // public void Ligar()
        // {
        //     Console.WriteLine($"Ligando ...");
            
        // }

        public void Desligar()

        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Desligando ...");
            Console.ResetColor();
        }

        public void Ligar()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Fazendo ligação...");
            Console.ResetColor();   
        }

        public void MandarMensagem()

        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Mandando mensagem...");
            Console.ResetColor();
        }




    }
}