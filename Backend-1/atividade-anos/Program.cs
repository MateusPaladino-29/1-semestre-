Console.WriteLine($"informe seu ano de nascimento");
int AnoNasci = int.Parse(Console.ReadLine());





int Anos = DateTime.Now.Year - AnoNasci ;

int Semanas = AnoNasci * 52;

Console.WriteLine(@$"

idade em Anos {Anos}

idade em semanas {Semanas}

");

