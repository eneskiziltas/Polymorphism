using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{

    public enum BreadType
    {
        Beyaz = 1,
        Kepek = 2,
        Bugday = 3,
        Odun = 4,
        AltinEkmek = 5
    }


    public enum Gramaj
    {
        Yuz = 100,
        YuzYirmiBes = 125,
        IkiYuz = 200
    }

    class Bread : Product
    {

        public BreadType Type { get; set; }
        public Gramaj Gram { get; set; }
        public string Uretici { get; set; }

        public Bread(BreadType type)
        {
            switch (type)
            {
                case BreadType.Beyaz:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Kepek:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Bugday:
                    this.Price = 1.0;
                    this.Gram = Gramaj.Yuz;
                    break;
                case BreadType.Odun:
                    this.Price = 2.0;
                    this.Gram = Gramaj.IkiYuz;
                    break;
                case BreadType.AltinEkmek:
                    this.Price = 1.5;
                    this.Gram = Gramaj.YuzYirmiBes;
                    break;
                default:
                    break;
            }
        }
    }
}
