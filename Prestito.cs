// See https://aka.ms/new-console-template for more information

//contenitore dati della banca
public class Prestito
{
    public int ID { get; set; }

    public int Ammontare { get; set; }  

    public int ValoreRata { get; set; }

    public DateOnly Inizio { get; set; }

    public DateOnly Fine { get; set; }

    public Cliente Intestatario { get; set; }

    public Prestito(int iD, int ammontare, int valoreRata, DateOnly inizio, DateOnly fine, Cliente intestatario)
    {
        ID = iD;
        Ammontare = ammontare;
        ValoreRata = valoreRata;
        Inizio = inizio;
        Fine = fine;
        Intestatario = intestatario;
    }

    //Prestito in data di oggi
    public Prestito(int iD, int ammontare, int valoreRata, DateOnly fine, Cliente intestatario)
    {
        ID = iD;
        Ammontare = ammontare;
        ValoreRata = valoreRata;
        Inizio = new DateOnly();
        Fine = fine;
        Intestatario = intestatario;
    }

}
