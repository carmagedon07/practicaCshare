// See https://aka.ms/new-console-template for more information

while (true)
{
    try
    {

        Console.Write("\n Ingresar edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.Write("Es mayor de edad");
        }
        else
        {
            Console.Write("Es menor de edad");

        }
    }
    catch (System.Exception)
    {
        Console.Write("ingresar un numero por favor");
        
    }
}


