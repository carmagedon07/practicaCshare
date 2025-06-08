while (true) {
    try
    {
        Console.WriteLine("ingresar un numero: ");
        int numeroK = Convert.ToInt32(Console.ReadLine());
        if (numeroK > 1 && numeroK <= 10)
        {
            Console.WriteLine("dentro del rango");
        }
        else
        {
            Console.WriteLine("Fuera de rango");
        }
    }
    catch (Exception)
    {

        Console.WriteLine("error inesperado");
    }
}


