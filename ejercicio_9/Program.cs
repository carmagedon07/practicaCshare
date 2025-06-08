

while (true) {
    try
    {
        Console.WriteLine("Poner año");
        int anio = Convert.ToInt32(Console.ReadLine());



        if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
        {
            Console.WriteLine("año bisiesto");
        }
        else
        {
            Console.WriteLine("años normal");
        }        

    }
    catch (Exception)
    {
        Console.WriteLine("error en el ");

    }
}
