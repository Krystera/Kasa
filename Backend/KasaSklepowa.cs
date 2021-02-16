using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Produkty = new List<Produkt>();
            Produkt p = new Produkt();
            p.Nazwa = "Mleko";
            p.Jednostka = "sztuk";
            p.Cena = 5;
            p.Barcode = "01";
            p.VAT = 0.23;
            Produkty.Add(p);

            Produkt r = new Produkt();
            r.Nazwa = "Sok";
            r.Jednostka = "sztuk";
            r.Cena = 5;
            r.Barcode = "02";
            r.VAT = 0.08;
            Produkty.Add(r);

            Produkt o = new Produkt();
            o.Nazwa = "Cola";
            o.Jednostka = "sztuk";
            o.Cena = 10;
            o.Barcode = "03";
            o.VAT = 0.23;
            Produkty.Add(o);
        }









    }
}
