3


while (true) {
    try {
        Console.WriteLine("Ingresar el primer numero");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresar segundo numero");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresar tercer numero");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        if (numero1 > numero2 && numero1 > numero3)
        {
            Console.WriteLine("es el Numero uno");
        }
        else if (numero2 > numero1 && numero2 > numero3)
        {
            Console.WriteLine("es el mayor Numero dos");
        }
        else {
            Console.WriteLine("es el Numero tres");
        }
            
    }catch (Exception ex) {
        Console.WriteLine(ex.ToString()); 
    }
}

