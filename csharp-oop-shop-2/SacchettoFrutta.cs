using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class SacchettoFrutta : Prodotto
    {
        //ATTRIBUTI
        private double quantitaFrutta;

        //COSTRUTTORE
        public SacchettoFrutta(string nome, string descrizione, double prezzo, int iva, double quantitaFrutta) : base(nome, descrizione, prezzo, iva)
        {
            this.quantitaFrutta = quantitaFrutta;
        }

        //GETTERS
        public double GetQuantitaFrutta()
        {
            return this.quantitaFrutta;
        }
    }
}
