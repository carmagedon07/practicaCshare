
while (true)
{
    try
    {
        Console.WriteLine("Cual es el total de la cuanta");
        int totalCuenta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("escriba el porcentajes de la propina (10 ,20,30)");
        int porcentajePropina = Convert.ToInt32(Console.ReadLine());

        if (porcentajePropina == 10 || porcentajePropina == 20 || porcentajePropina == 30)
        {
            float totalPropina = ((float)porcentajePropina / 100f) * totalCuenta;

            string msg = "la propina total a dar con el porcentaje de  " + porcentajePropina + " es de: " + totalPropina;

            Console.WriteLine(msg);
        }
        else
        {
            Console.WriteLine("La propina esta fuera del rango");
        }

        
    }
    catch (Exception)
    {

        Console.WriteLine("Error inesperado");
    }
}
