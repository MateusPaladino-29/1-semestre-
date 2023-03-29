Console.WriteLine($"Informe sua idade");
int Idade = int.Parse(Console.ReadLine());


int IdadeMeses = Idade * 12;
int IdadeDias = IdadeMeses * 30;
int IdadeHoras = IdadeDias * 24;
int IdadeMinutos = IdadeHoras * 60;

Console.WriteLine(@$"
    idade em meses {IdadeMeses}
    idade em dias {IdadeDias}
    idade em horas {IdadeHoras}
    idade em minutos {IdadeMinutos}
");

















