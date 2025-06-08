Boolean salir = true;
int numeroUser = 0;
Random rnd = new Random();
int numeroObjectivo = rnd.Next(1, 101);

while (salir)
{
    try
    {
        
       
        Console.WriteLine("Escribir un numero entre 1 y 101");

        numeroUser = Convert.ToInt32(Console.ReadLine());
        if (numeroUser == numeroObjectivo)
        {
            Console.WriteLine("Adivino el numero secreto");
            salir = false;
        }
        else
        {
            if (numeroUser < numeroObjectivo)
            {
                Console.WriteLine("el numero es mayor al de numero ha adivinar");
            }
            else
            {
                Console.WriteLine("el numero es menor al de numero ha adivinar");
            }
        }
        


    }
    catch (Exception)
    {

        Console.WriteLine("error inesperado");
    }
}
