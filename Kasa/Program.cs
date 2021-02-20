using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa
{
    class Program
    {
        static void Main(string[] args)
        {   
            KasaSklepowa kasaSklepowa = new KasaSklepowa();

            Console.WriteLine("Lista produktów dostępnych w sklepie: ");
            Console.WriteLine();
          

            WyswietlaniePetli wyswietlaniePetli = new WyswietlaniePetli();

            wyswietlaniePetli.WyswietlProdukty();
            

            int kasiorka = 0;
            int calosc = 0;
            do { 
            

            

                Console.WriteLine();
                Console.WriteLine("Podaj Barcode produktu : ");
                string barcode = Console.ReadLine();

                Produkt p = kasaSklepowa.Produkty.FirstOrDefault(x => x.Barcode == barcode);

                




                if (p != null)
                { Produkt y = new Produkt();
                    Console.WriteLine("Podaj Ilość produktu : ");
                    string v = Console.ReadLine();
                    int q = int.Parse(v);
                    


                    kasaSklepowa.DodajDoKoszyka(p, q);
                     kasiorka = p.Cena * q;

                }
                else
                {
                    Console.WriteLine("Nie mamy takiego produktu ;(");


                }

                

                Console.WriteLine();
                Console.WriteLine("Lista produktów w Twoim Koszyku: ");


                foreach (ItemekWKoszyku a in kasaSklepowa.Koszyk.Itemki)
                {

                    Console.WriteLine($"{a.Produkt.Nazwa}, Ilość Produktów: {a.Ilosc}");

                }

                
              

                Console.WriteLine();
                Console.WriteLine("Chcesz coś jeszcze dodać do koszyka? Tak/Nie");
                calosc = kasiorka + calosc;
            }
            while (!Console.ReadLine().StartsWith("Nie", StringComparison.InvariantCultureIgnoreCase));

            
            Console.WriteLine();
            Console.WriteLine();
            
            


            int ileTego = 0;
            
            foreach (ItemekWKoszyku aa in kasaSklepowa.Koszyk.Itemki)
            {
                
               

                ileTego = aa.Ilosc + ileTego;
                

               
            }

 //gggggggggggg
            
            
            DateTime thisDay = DateTime.Today;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Twój Paragon: ");
            Console.WriteLine();
            Console.WriteLine($"Data sprzedaży: {thisDay.ToString("d")}");
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            foreach (ItemekWKoszyku a in kasaSklepowa.Koszyk.Itemki)
            {
               

                Console.WriteLine($"{a.Produkt.Nazwa}     {a.Ilosc}   {a.Produkt.Cena*a.Ilosc} PLN");

            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine($"ŁĄCZNIE DO ZAPŁATY: {calosc} PLN");
            Console.WriteLine("W tym:");
            double vat8 = 0;
            double vat23 = 0;
            foreach (ItemekWKoszyku a in kasaSklepowa.Koszyk.Itemki)
            {
                
      
                    if (a.Produkt.VAT.Equals(0.08))
                       vat8 = vat8 + (a.Produkt.VAT * a.Produkt.Cena * a.Ilosc);



                if (a.Produkt.VAT.Equals(0.23))
                    vat23 = vat23 + (a.Produkt.VAT * a.Produkt.Cena * a.Ilosc);
                       
              
            }
            Console.WriteLine($"VAT 8%: {vat8} PLN");
            Console.WriteLine($"VAT 23%: {vat23} PLN");

            Console.ReadLine();

        }

       



        

    }




}
