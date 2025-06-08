using System;
using System.Globalization;
while (true)
{
    try
    {
        Console.WriteLine("ingrese peso en kg");
        string pesoStr = Console.ReadLine();

        Console.WriteLine("ingrese altura en (m)");
        string alturaStr = Console.ReadLine();

        float pesoNum = float.Parse(pesoStr,CultureInfo.InvariantCulture);
        float alturaNum = float.Parse(alturaStr,CultureInfo.InvariantCulture);


        float imcValue = pesoNum / (alturaNum * alturaNum);

        Console.WriteLine(imcValue);
        if (imcValue < 18.5) {
            Console.WriteLine("bajo de peso");
        } else if (imcValue >= 18.5 && imcValue < 25) {
            Console.WriteLine("Normal");
        } else if (imcValue >= 25 && imcValue < 30) { 
            Console.WriteLine("Sobrepeso");
        }else { 
            Console.WriteLine("Obesidad");
        }
    }
    catch (Exception)
    {

        Console.WriteLine("lo valorese numerico que ingresa debe ser numericos");
    } 

}
