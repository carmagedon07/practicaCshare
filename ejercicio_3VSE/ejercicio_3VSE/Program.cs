while (true)
{
    try
    {
        List<string> nombres = new List<string>();
        Boolean isOutList = true; // Cambiado a true para que el bucle se ejecute

        while (isOutList)
        {
            Console.WriteLine("Seleccionar una opción:\n1. Ingresar nombre\n2. Terminar");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 2)
            {
                isOutList = false; // Salir del bucle interno
                Console.WriteLine("Nombres registrados:");
                if (nombres.Count != 0)
                {
                    foreach (string nombre in nombres)
                    {
                        Console.WriteLine(nombre);
                    }
                }
                    
            }
            else
            {
                Console.WriteLine("Agregar nombre:");
                string nombre = Console.ReadLine();
                nombres.Add(nombre);
            }
        }

        
            
        
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}