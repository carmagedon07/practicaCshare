while (true)
{
    try {

        Console.WriteLine("Ingresar la edad: ");
        int numberEdad=Convert.ToInt32(Console.ReadLine());

        if (numberEdad < 0 || numberEdad > 120)
        {
            Console.WriteLine("edad no valida");
        }
        else {
            Console.WriteLine("Rango correcto de edad");
        }
    
    } catch (Exception ex) { 

    } 
}