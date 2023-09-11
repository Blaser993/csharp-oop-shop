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
        public int Codice { get; private set; }
        public string Nome { get; set; }
        public string Descrizione { get;  set; }
        public float Prezzo { get; set; }
        public int Iva { get; set; }

        // STATI
        public bool disponibilita;


        // COSTRUTTORI
        public Prodotto( string nome, string desc, float prezzo, int iva)
        {
            this.Codice = new Random().Next(1, 99999999);
            this.Nome = nome;
            this.Descrizione = desc;
            this.Prezzo = prezzo;
            this.Iva = iva;
            this.disponibilita = true;
        }

        //GETTER

        //SETTER


        //METODI

        public void LeggiPrezzo ()
        {
            Console.WriteLine($"Il prezzo per questo prodotto è {this.Prezzo} euro");
        }

        public void LeggiPrezzoIvato () 
        {
            float prezzoIvato = this.Prezzo * this.Iva / 100;
            Console.WriteLine($"Il prezzo più iva di questo prodotto è di {prezzoIvato}");
        }
  

        public void LeggiCodiceNome()
        {
            // Formatta il tipo int in string e ne aggiunge gli zeri a seinistra  se necessario.
            string codiceFormattato = this.Codice.ToString("D8");

            string nomeCompleto = "[" + codiceFormattato + "]" + this.Nome;

            Console.WriteLine($"{nomeCompleto}");
        }



    }
}
