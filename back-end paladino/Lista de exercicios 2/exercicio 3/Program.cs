
Console.WriteLine($"qual o raio da circuferencia?");
double raio = double.Parse(Console.ReadLine());


 double Diametro = raio * Math.PI;
 double comprimento =  Diametro *  Math.PI * Math.Pow(1,2);
 double area =  raio * raio * Math.PI;

 Console.WriteLine(@$"
    Diametro vai ser igual {Diametro}
    Comprimento vai ser igual {comprimento}
    area da circuferencia vai ser igual {area}
 ");
 



