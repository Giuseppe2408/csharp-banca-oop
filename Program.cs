// See https://aka.ms/new-console-template for more information

//contenitore dati della banca
using System.Reflection.Metadata.Ecma335;
Bank intesa = new Bank("Intesa San Paolo");


Console.WriteLine("benvenuto in" + intesa.Nome);


//inserimento cliente
Console.WriteLine("inserisci codice fiscale");
string codiceFiscale = Console.ReadLine();

bool esitoInserimento = intesa.AggiungiCliente("test", "test", codiceFiscale, 0);

if (esitoInserimento)
{
    Console.WriteLine("inserimento avvenuto con successo");
} else
{
    Console.WriteLine("errore: impossibile inserire");
}
//inserimento cliente finito


// aggiunta prestito
// chiedo all'utente di cercare il cliente su cui applicare il prestito
Console.WriteLine("creazione nuovo prestito");
Console.WriteLine();
Console.WriteLine("inserisci codice fiscale");
string codiceFiscale1 = Console.ReadLine();

Cliente esistente = intesa.RicercaCliente(codiceFiscale1);
if (esistente == null)
{
    Console.WriteLine("cliente non trovato");
} 
else
{
    Console.WriteLine("ammonatre prestito: ");

    int ammontarePrestito = Convert.ToInt32(Console.ReadLine());

    Prestito nuovoPrestito = new Prestito(0,ammontarePrestito,0,new DateOnly(), esistente);

    intesa.AggiungiPrestito(nuovoPrestito);

}
