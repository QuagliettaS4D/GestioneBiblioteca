// See https://aka.ms/new-console-template for more information
using Gestione_Biblioteca;

Console.WriteLine("Gestione Biblioteca");
Console.WriteLine("Inserimento libri");

Libro[] biblioteca = new Libro[500];
int indice = 0;

bool continua = true;
while (continua)
{
    //sintassi di creazione di un oggetto da una classe
    //nome classe //nome oggetto //parola chiave // nome classe
    Libro oggettoLibro = new Libro();

    Console.WriteLine("inserisci il titolo:");
    oggettoLibro.Titolo = Console.ReadLine();

    Console.WriteLine("inserisci l'autore:");
    oggettoLibro.Autore = Console.ReadLine();

    Console.WriteLine("inserisci il numero di pagine:");
    oggettoLibro.Pagine = int.Parse(Console.ReadLine());

    Console.WriteLine("inserisci il prezzo:");
    oggettoLibro.Prezzo = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Il prezzo in dollari sarà: " + oggettoLibro.PrezzoInDollari());

    biblioteca[indice] = oggettoLibro;
    indice++;

    Console.WriteLine("Vuoi inserire un altro libro (S/N)?");
    string risposta = Console.ReadLine();
    if (risposta == "N") continua = false;
}