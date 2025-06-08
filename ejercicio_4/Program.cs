// See https://aka.ms/new-console-template for more information
while (true)
{
    try
    {
        string contraseniaBD = "python123";

        Console.WriteLine("Ingresar contraseña");

        string contraseniaUser = Console.ReadLine();

        if (contraseniaUser!=null && contraseniaUser.Equals(contraseniaBD))
        {
            Console.WriteLine("Has ingresado al aplicativo");

        }
        else
        {
            Console.WriteLine("contraseña incorrecta");
        }
    }
    catch (Exception)
    {
         Console.WriteLine("error inesperado");
        
    }

}


