using ListaAppuntamenti;

Console.WriteLine("------AGENDA APPUNTAMENTI-----");

List<Appuntamento> listaAppuntamenti = new List<Appuntamento>();

Console.WriteLine("Benvenuto");
Console.WriteLine("Quanti appuntamenti vuoi prenotare?");

int numeroDiAppuntamenti = ChiediNumeroDiAppuntamenti();
{
    throw new NotImplementedException();
}

for (int i = 0; i < numeroDiAppuntamenti; i++)
{
    Console.WriteLine("Appuntamento numero " + (i + 1));
    Console.WriteLine("Aggiungi il nome del tuo appuntamento: ");
    string nomeAppuntamento = Console.ReadLine();
    Console.WriteLine("Aggiungi il luogo del tuo appuntamento: ");
    string localitaAppuntamento = Console.ReadLine();

    bool dataCorretta = false;
    while (dataCorretta)
    {
        DateTime dataOraAppuntamento = InserisciUnaData();
        try
        {
            listaAppuntamenti.Add(new Appuntamento(nomeAppuntamento, localitaAppuntamento, dataOraAppuntamento));
            dataCorretta = true;
        }
        catch (InvalidDataException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}


//FUNZIONI 

int ChiediNumeroDiAppuntamenti()
{
    int numeroDiAppuntamenti = 0;
    bool numeroDiAppuntamentiCorretto = false;
    while (!numeroDiAppuntamentiCorretto)
    {
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            numeroDiAppuntamenti = result;
            numeroDiAppuntamentiCorretto = true;
        }
        else
        {
            Console.WriteLine("Inserisci un numero intero");
        }
    }
    return numeroDiAppuntamenti;
}

DateTime InserisciUnaData()
{
    bool formatoDataCorretto = false;
    DateTime dataOra = DateTime.Now;
    while (!formatoDataCorretto)
    {
        Console.WriteLine("Aggiungi la data e l' ora del tuo appuntamento: [gg/mm/aa]");
        try
        {
            dataOra = DateTime.Parse(Console.ReadLine());
            formatoDataCorretto=true;
        }catch (Exception)
        {
            Console.WriteLine("Il formato della data non è corretto");
        }
    }
    return dataOra;
}















