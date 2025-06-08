
while (true)
{

    try
    {
        Console.WriteLine("Colocar el primer numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Colocar el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 < numero2) {

            Console.WriteLine("El numero uno es mayor que el numero 2");

        } else if (numero1==numero2) {
            Console.WriteLine("El numero uno es igual que el numero 2");

        } else {
            Console.WriteLine("El numero dos es mayor que el numero uno");
        }

    }
    catch (Exception)
    {
        Console.WriteLine("Error inesperado");
        
    }
}