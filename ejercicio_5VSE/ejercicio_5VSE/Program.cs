while (true) {
    try
    {
        Boolean isInvitadoInner = false;

        List<string> invitados = new List<string>{"Ana", "Luis", "Sofia"};
        Console.WriteLine("Ingresar nombre en la lista");
        String usuario = Console.ReadLine();

        if (usuario != null) {
            foreach (String invitado in invitados)
            {
                if (usuario== invitado) {
                    Console.WriteLine("invitado encontrado");
                    isInvitadoInner= true;
                    break;

                }
            }
            if (!isInvitadoInner) {
                Console.WriteLine("usuario no encontrado");
            }

        }

        Console.WriteLine();
    }
    catch (Exception ex) { 
    }
}
