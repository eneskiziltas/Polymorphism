using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {


            Basket basket = new Basket();

            Bread ekmek = new Bread(BreadType.Odun);
            
            ekmek.ProcutName = BreadType.Odun.ToString();
            Tekstil tekstil = new Tekstil();
            tekstil.Marka = TekstilMarka.Beymen;
            tekstil.ProcutName = "Özel Dikim";
            tekstil.Price = 250.5;

            basket.Add(ekmek);
            basket.Add(tekstil);


            Console.WriteLine("Toplam fiyat (KDV Hariç) : " + basket.TotalPrice());
            Console.WriteLine("Toplam fiyat (KDV Dahil) : " + basket.TotatlPriceWithKDV());

            Console.WriteLine("*************");

            foreach(var product in basket.GetProducts())
            {
                Console.WriteLine(product.ProcutName);
            }


            Console.ReadLine();

        }
    }
}
