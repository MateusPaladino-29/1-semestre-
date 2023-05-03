


Console.WriteLine($"informe o primeiro numero");
float n1 = float.Parse(Console.ReadLine());     

Console.WriteLine($"informe o segundo numero");
float n2 = float.Parse(Console.ReadLine());


static float Soma(float n1, float n2)
{
    float r = n1 + n2;
    return r;
}

static float multiplicador(float n1, float n2)
{
    float r = n1 * n2;
    return r;
}

static float divisao(float n1, float n2)
{
    float r = n1 / n2;
    return r;
}

static float subtracao(float n1, float n2)
{
    float r = n1 - n2;
    return r;
}

float resultado = Soma(n1, n2);
float resultadoM = multiplicador(n1, n2);
float resultadoD = divisao(n1, n2);
float resultadoS = subtracao(n1, n2);

Console.WriteLine(@$" 
 resultado geral
 resultado da soma: {resultado}
 resultado da multiplicação: {resultadoM}
 resultado da divisão: {resultadoD}
resultado da subtração: {resultadoS}
");