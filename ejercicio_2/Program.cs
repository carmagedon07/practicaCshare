// See https://aka.ms/new-console-template for more information


while (true)
{
    try
    {
       Console.Write("\n Ingresar un numero ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero >= 0)
    {
        Console.Write("numero positivo");
    }
    else
    {
        Console.Write("numero negativo");
    }
 
    }
    catch (Exception)
    {
        Console.Write("debe ingresarse un numero");
        
    }
    
}

