﻿// See https://aka.ms/new-console-template for more information

//contenitore dati della banca
using System.Reflection.Metadata.Ecma335;
Bank intesa = new Bank("Intesa San Paolo");


Console.WriteLine("benvenuto in" + intesa.Nome);


//inserimento cliente
Console.WriteLine("inserisci codice fiscale");
string codiceFiscale = Console.ReadLine();

bool esitoInserimento = intesa.AggiungiCliente("test", "test", codiceFiscale, 700);

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
codiceFiscale = Console.ReadLine();

Cliente esistente = intesa.RicercaCliente(codiceFiscale);
if (esistente == null)
{
    Console.WriteLine("cliente non trovato");
} 
else
{
    Console.WriteLine("ammontare prestito: ");

    int ammontarePrestito = Convert.ToInt32(Console.ReadLine());

    Prestito nuovoPrestito = new Prestito(0,ammontarePrestito,new DateOnly(2025,12,25), esistente);
    ammontarePrestito = Convert.ToInt32(Console.ReadLine());
    Prestito nuovoPrestito1 = new Prestito(1, ammontarePrestito, 100, new DateOnly(2026, 05, 12), esistente);

    bool prestitoRiuscito = intesa.AggiungiPrestito(nuovoPrestito);
    bool prestitoRiuscito1 = intesa.AggiungiPrestito(nuovoPrestito1);


    if (prestitoRiuscito || prestitoRiuscito1)
    {
        Console.WriteLine("prestito avvenuto con successo");
    }
    else
    {
        Console.WriteLine("errore: impossibile fare il prestito");
    }

    
}

Console.WriteLine();
Console.WriteLine("vuoi vedere la lista dei prestiti di un cliente? inserici si/no");
string sceltaUtente = Console.ReadLine();


if (sceltaUtente == "si")
{
    Console.WriteLine("inserisci codice fiscale utente");
    codiceFiscale = Console.ReadLine();
    List<Prestito> prestitiCodiceFiscale = intesa.RicercaPrestito(codiceFiscale);

    if (prestitiCodiceFiscale == null)
    {
        Console.WriteLine("nessun prestito trovato");
    } 
    else
    {
        foreach (Prestito prestito in prestitiCodiceFiscale)
        {
            Console.WriteLine("questi sono i prestiti dell'utente");
            Console.WriteLine("somma richiesta : " + prestito.Ammontare + " Valore rata: " + prestito.ValoreRata + " fatto in data: " + prestito.Inizio + " finisce in data: " + prestito.Fine);
        }

        Console.WriteLine("vuoi sapere anche l'ammontare della somma dei prestiti fatti dell'utente?");
        sceltaUtente = Console.ReadLine();


        if (sceltaUtente == "si")
        {
            
            int sommaPrestiti = intesa.AmmontareTotalePrestiti(codiceFiscale);

            if (sommaPrestiti > 0)
            {
                Console.WriteLine("la somma totale dei prestiti è : " + sommaPrestiti);
                Console.WriteLine("vuoi sapere anche le rate rimanenti?");
                sceltaUtente = Console.ReadLine();
                if (sceltaUtente == "si")
                {
                    int rateMancanti = intesa.RateMancanti(codiceFiscale, 0);

                    Console.WriteLine("al cliente mancano da pagare " + rateMancanti + "rate");
                }
            }
            else
            {
                Console.WriteLine("l'utente non ha prestiti");
            }
        }
    }


}