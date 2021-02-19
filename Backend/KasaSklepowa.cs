using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Backend
{
    public class KasaSklepowa
    {

        public KasaSklepowa()
        {
            StworzProdukty();
            Koszyk = new Koszyk();
        }

        public List<Produkt> Produkty { get; set; }

        public Koszyk Koszyk { get; set; }

        public void DodajDoKoszyka(Produkt p, int ilosc)
        {
            Koszyk.DodajDoKoszyka(p, ilosc);
        }

        public void StworzProdukty()
        {
            var sciezka = Directory.GetCurrentDirectory() + "\\produkty.json";
            var content = File.ReadAllText(sciezka);
            Produkty = JsonConvert.DeserializeObject<List<Produkt>>(content);

         
        }









    }
}
