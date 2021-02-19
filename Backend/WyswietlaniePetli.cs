using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class WyswietlaniePetli
    {
        KasaSklepowa kasaSklepowa = new KasaSklepowa();


        public void WyswietlProdukty()
        {

            foreach (Produkt s in kasaSklepowa.Produkty)
            {

                Console.WriteLine($"BARCODE: {s.Barcode}    {s.Nazwa}, {s.Cena} PLN za {s.Jednostka} ");

            }
        }

     
        }
    }



