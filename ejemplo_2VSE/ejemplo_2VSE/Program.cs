while (true) {
    try {

        Boolean isFindNumber = false;

        List<int> listNumber = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("Ingresar un nuero para validar existencia en la lista");

        int userNumber =Convert.ToInt32( Console.ReadLine());

        foreach (int item in listNumber)
        {
            if (item == userNumber) {
                isFindNumber=true;
                break;
            }
        }

        if (!isFindNumber)
        {
            Console.WriteLine("Numero no esta en la lista");
        }
        else {
            Console.WriteLine("Numero en la lista");
        }

    }
    catch (Exception) { 
    
    }
}