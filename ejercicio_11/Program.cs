using System.Net;
using System.Text;

Boolean isStillInProgram = true;
Dictionary<string, Dictionary<string, string>> biblioteca = new Dictionary<string, Dictionary<string, string>>();
int contadorLibro = 0;
while (true)
{
    try
    {

        int numberOption = mostrarMenu();
        switch (numberOption)
        {
            case 1:
                biblioteca = addLibro(biblioteca);
                break;

            case 2:
                int opcionSubmenu = mostrarSubmenu1();
                if (opcionSubmenu == 1)
                {
                    mostrarTodos(biblioteca);
                }
                else if (opcionSubmenu == 2)
                {

                    buscarLibro(biblioteca);
                }
                else
                {
                    continue;
                }
                break;
            default:
                Console.WriteLine("opcion invalida");
                break;
        }
    }
    catch (Exception ex)
    {


    }

}



int mostrarSubmenu1()
{
    int opcionNumber = 0;
    StringBuilder submenu2 = new StringBuilder("Selecione una opcion de busqueda:\n");
    submenu2.Append("1. listar todos los libros: ");
    submenu2.Append("2. buscar libro id o titulo: ");
    Console.WriteLine(submenu2);            
    opcionNumber = Convert.ToInt32(Console.ReadLine());
    return opcionNumber;
}

void buscarLibro(Dictionary<string, Dictionary<string, string>> biblioteca)
{
    int submenuVar2 = submenu2();
    if (submenuVar2 == 1)
    {
        Console.WriteLine("ingresar el id");
        string idSearch = Console.ReadLine();
        Console.WriteLine("ingresar el titulo");
        string titulo = Console.ReadLine();

        if (biblioteca.TryGetValue(idSearch, out Dictionary<string, string> libro))
        {
            foreach (KeyValuePair<string, string> data in libro)
            {
                if (data.Key == "Titulo" && data.Value == titulo)
                {
                    StringBuilder msg = new StringBuilder("la informacion solicitada \n");
                    foreach (KeyValuePair<string, string>  databook in libro)
                    {
                        msg.Append($"{databook.Key} : {databook.Value} \n");
                        
                    }
                    
                    Console.WriteLine(msg);
                }
                else
                {
                    mensajeNoFound();
                }
            }
        }
        else
        {
            mensajeNoFound();
        }
    }
    else
    {
        Console.WriteLine("Opcion no valida");
    }

} 

void mensajeNoFound()
{ 
    Console.WriteLine("Libro no encontrado");
}  

int submenu2()
{
    StringBuilder menu = new StringBuilder("Selecione el criterio de busqueda:");
    menu.Append("1. por id");
    menu.Append("2. por titulo");

    Console.WriteLine(menu);
    int opcionMenu = Convert.ToInt32(Console.ReadLine());

    return opcionMenu;
}


void mostrarTodos(Dictionary<string, Dictionary<string, string>> biblioteca)
{
    foreach (KeyValuePair<string, Dictionary<string, string>> libro in biblioteca)
    {
        string idLibro = libro.Key;
        Console.WriteLine($"--- ID del Libro: {idLibro} ---");
        Dictionary<string, string> detallesLibro = libro.Value;
       
        foreach (KeyValuePair<string, string> data in detallesLibro)
        {
            Console.WriteLine($" {data.Key}:{data.Value}");
        }
    }
}

Dictionary<string, Dictionary<string, string>> addLibro(Dictionary<string, Dictionary<string, string>> biblioteca)
{
    // crear libro
    Dictionary<string, string> libro = new Dictionary<string, string>();
    string autor = "";
    string titulo = "";
    string contadorStr = "";
    int anio = 0;
    libro = crearLibro(titulo,autor,contadorStr,anio);
    contadorStr = numeradorLibro(contadorLibro);
    biblioteca.Add(contadorStr.ToString(), libro);
    Console.WriteLine("El libro fue guardado en la base de datos de la libreria");


    return biblioteca;
}

Dictionary<string, string> crearLibro (string titulo,string autor, string contadorStr,int anio)
{
    Dictionary<string, string> libro = new Dictionary<string, string>();
    Console.WriteLine("Digitar el titulo del libro: ");
    titulo = Console.ReadLine();
    Console.WriteLine("Ingreasar el autor del libro");
    autor = Console.ReadLine();
    Console.WriteLine("Ingresar el año de publicacion (valor numerico): ");
    anio = Convert.ToInt32(Console.ReadLine());
    libro.Add("Titulo", titulo);
    libro.Add("Autor", autor);
    libro.Add("Año", anio.ToString());
    return  libro;
}

string numeradorLibro(int contadorLibro)
{ 
    StringBuilder contadorStr = new StringBuilder();
    contadorLibro = contadorLibro++;
    contadorStr.Append("0");
    if (contadorLibro < 9)
    {
        contadorStr.Append("0");
    }
    contadorStr.Append(contadorLibro.ToString());
    return contadorStr.ToString();
}

int mostrarMenu()
{
    StringBuilder menu = new StringBuilder();

        menu.Append("----Bienvenido al sistema de gestion de la biblioteca-----\n");
        menu.Append("1. Crear nuevo libro \n");
        menu.Append("2.Leer/Buscar libros \n");
        menu.Append("3.Actualizar información de libro \n");
        menu.Append("4. Eliminar libro \n");
        menu.Append("5. Salir \n");
        Console.WriteLine(menu);
    return Convert.ToInt32(Console.ReadLine());
}
