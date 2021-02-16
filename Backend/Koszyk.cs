using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Koszyk
    {
        public Koszyk()
        {

            Itemki = new List<ItemekWKoszyku>();

        }

        public List<ItemekWKoszyku> Itemki { get; set; }

        public void DodajDoKoszyka(Produkt p, int ilosc)
        {
            ItemekWKoszyku itemek = new ItemekWKoszyku();
            itemek.Produkt = p;
            itemek.Ilosc = ilosc;
           

            Itemki.Add(itemek);

        }

    }
}
