using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //METHODS
        public void RiempiSacchetto(double quantitaFrutta)
        {
            if (this.quantitaFrutta <= 5)
            {
                this.quantitaFrutta = quantitaFrutta;
                Console.WriteLine("Numero frutta al suo interno: " + quantitaFrutta);
            }
            else
            {
                Console.WriteLine("Hai raggiunto la quantità massima di pezzi di frutta");
                this.quantitaFrutta = 0;
            }
        }

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.Write("Numero frutta al suo interno: " + quantitaFrutta);
            Console.WriteLine("-----------------------------------");
        }
    }
}
