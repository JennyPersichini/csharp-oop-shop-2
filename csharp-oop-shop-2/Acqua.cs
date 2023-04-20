using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Acqua : Prodotto
    {
        //ATTRIBUTI
        private double litri = 1.5;
        private int ph;
        private string sorgente;

        //COSTRUTTORE
        public Acqua(string nome, string descrizione, double prezzo, double iva, double litri, int ph, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
        }
        
        //GETTERS
        public double GetLitri()
        {
            return this.litri;
        }

        public double GetPh()
        {
            return this.ph;
        }

        public string GetSorgente()
        {
            return this.sorgente;
        }

        //METODI
       


    }
}
