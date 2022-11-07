// See https://aka.ms/new-console-template for more information

//contenitore dati della banca
public class Cliente
{
    public string Nome { get; set; }

    public string Cognome { get; set; }

    public string CodiceFiscale { get; set; }

    public int Stipendio { get; set; }

    //qui non serve la lista è già dentro bank
    //public List<Prestito> Prestiti { get; set; }

    public Cliente(string nome, string cognome, string codiceFiscale, int stipendio)
    {
        Nome = nome;
        Cognome = cognome;
        CodiceFiscale = codiceFiscale;
        Stipendio = stipendio;
    }
}
