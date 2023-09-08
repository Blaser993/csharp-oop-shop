using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        // ATTRIBUTI
        public int codice {  get; private set; }
        public string nome { get; set; }
        public string descrizione { get;  set; }
        public float prezzo { get; set; }
        public int iva { get; set; }

        // STATI
        public bool disponibilita;


        // COSTRUTTORI
        public Prodotto(int num, string nome, string desc, float prezzo, int iva)
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
  

        public void LeggiCodiceNome()
        {
            // Formatta il tipo int in string e ne aggiunge gli zeri a seinistra  se necessario.
            string codiceFormattato = this.codice.ToString("D8");

            string nomeCompleto = "[" + codiceFormattato +"] "  + this.nome;

            Console.WriteLine($"Il nome completo del tuo prodotto è {nomeCompleto}");
        }

        public void SchedaProdotto()
        {

        }

    }
}
