// See https://aka.ms/new-console-template for more information

//contenitore dati della banca
//chiedo i dati del prestito
//aggiungo il prestito

public class Bank
{
    public string Nome { get; set; }
    
    private List<Cliente> Clienti { get;  set; }

    private List<Prestito> Prestiti { get;  set; }

    public Bank(string nome)
    {
        Nome = nome;
        Clienti = new List<Cliente>();
        Prestiti = new List<Prestito>();
    }

    public Cliente RicercaCliente(string codiceFiscale)
    {
        Cliente trovato = null;

        foreach(Cliente cliente in Clienti)
        {
            if(cliente.CodiceFiscale == codiceFiscale)
                return cliente;
        }

        return trovato;
    }

    public List<Prestito> RicercaPrestito(string codiceFiscale)
    {
        List<Prestito> prestitiTrovati = new List<Prestito>();

        //algoritmo ricerca

        return prestitiTrovati;
    }

    public bool AggiungiCliente(string nome, string cognome, string codiceFiscale, int stipendio)
    {
        //quando manca uno di questi parametri ritorna false
        if(nome == null || nome == "" ||
           cognome == null || cognome == "" ||
           codiceFiscale == null || codiceFiscale == "" ||
           stipendio < 0
           )
        {
            return false;
        }

        Cliente esistente = RicercaCliente(codiceFiscale);

        //Se il cliente esiste l'istanza sarà diversa dal null
        if(esistente != null)
        {
            return false;
        }

        Cliente cliente = new Cliente(nome, cognome, codiceFiscale, stipendio);
        Clienti.Add(cliente);

        return true;
    }


    public int AmmontareTotalePrestiti(string codiceFiscale)
    {
        int rateMancanti = 0; //metto il conteggio

        return rateMancanti;
    }


    public void StampaProspettoClienti()
    {
        //stampare per tutti i clienti
    }

    internal void AggiungiPrestito(Prestito nuovoPrestito)
    {
        if (nuovoPrestito.)
    }
}
