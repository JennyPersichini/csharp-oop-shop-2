// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using csharp_oop_shop_2;

//prodotto(nome, descrizione, prezzo, iva, litri, ph, sorgente)

Acqua bottiglia = new Acqua("Vitasnella", "Acqua naturale", 0.5, 5, 1.5, 7, "vitas");
bottiglia.StampaProdotto();
/*bottiglia.Bevi(0.6);
bottiglia.StampaTutto();
bottiglia.Riempi(0.9);
bottiglia.StampaTutto();*/

//prodotto(nome, descrizione, prezzo, iva, quantitaFrutta)

SacchettoFrutta Sacco1 = new("Mele", "Sacchetto di mele verdi", 3.5, 10, 4);

Sacco1.StampaProdotto();
/*SaccoUno.AggiungiFrutto("Sasso");
SaccoUno.StampaTutto();*/
