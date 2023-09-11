// See https://aka.ms/new-console-template for more information


/*
Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti di uno shop.
Un prodotto è caratterizzato da:
-codice (numero intero)
-nome
-descrizione
-prezzo
-iva

Usate opportunamente i livelli di accesso (public, private), i costruttori,
i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
-alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
-Il codice prodotto sia accessibile solo in lettura
-Gli altri attributi siano accessibili sia in lettura che in scrittura
-Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
-Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
-Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci per testare tutti i metodi che avete previsto.
*/

using csharp_oop_shop;

Prodotto prodotto1 = new Prodotto( "Spazzolino elettrico","", 24.5f, 22  );
Prodotto prodotto2 = new Prodotto( "Dentifricio", "", 0.99f, 22);
Prodotto prodotto3 = new Prodotto( "Cibo per cani", "", 40f, 22);
Prodotto prodotto4 = new Prodotto( "Assorbenti", "", 12.9f, 0);
Prodotto prodotto5 = new Prodotto( "Mazza da golf", "", 124.66f, 22);

Console.WriteLine($"Prodotto1: {prodotto1.Nome}");
prodotto1.LeggiPrezzo();
prodotto1.LeggiPrezzoIvato();
prodotto1.LeggiCodiceNome();

/*
BONUS:
create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri
(ad esempio codice 91 diventa 00000091, mentre codice 12344556 resta come è)
Usando un array fisso di 5 prodotti, dichiarate un elenco dei prodotti di un negozio 
e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio. 
Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio. 
 */

Prodotto[] negozio = {prodotto1, prodotto2, prodotto3, prodotto4, prodotto5 };

Console.WriteLine($"All'interno del negozio ci sono i seguenti prodotti: ");


/*for (int i = 0; i < negozio.Length; i++)
{
    string nomeCompleto = negozio[i].LeggiCodiceNome();
    Console.WriteLine($"Nome del prodotto {i+1} è: {negozio[i].Nome}");
}

*/

for (int i = 0; i < negozio.Length; i++)
{
    Console.Write($"Nome del prodotto {i + 1} è: ");
    negozio[i].LeggiCodiceNome();
}  

