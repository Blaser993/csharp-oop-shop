using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        // ATTRIBUTI
        public uint codice {  get; private set; }
        public string nome { get; set; }
        public string descrizione { get;  set; }
        public float prezzo { get; set; }
        public int iva { get; set; }

        // STATI
        public bool disponibilita;


        // COSTRUTTORI
        public Prodotto(uint num, string nome, string desc, float prezzo, int iva)
        {
            this.codice = num;
            this.nome = nome;
            this.descrizione = desc;
            this.prezzo = prezzo;
            this.iva = iva;
  
        }

        //METODI

        public void LeggiPrezzo ()
        {
            Console.WriteLine($"Il prezzo per questo prodotto è {this.prezzo} euro");
        }

        public void LeggiPrezzoIvato () 
        {
            float prezzoIvato = this.prezzo * this.iva / 100;
            Console.WriteLine($"Il prezzo più iva di questo prodotto è di {prezzoIvato}");
        }

        public void LeggiCodiceNome () 
        {
            string nomeCompleto = this.codice +" - "+ this.nome;
            Console.WriteLine($"Il nome completo del tuo prodotto è {nomeCompleto}");
        }
    }
}
