using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Product
    {
        public int ProdcutId { get; set; }

        public string ProductCode { get; set; }

        public string ProcutName { get; set; }

        public double Price { get; set; }

        public Product()
        {

        }

        public Product(
            int productId,
            string productCode,
            string productName,
            double price)
        {
            this.ProdcutId = productId;
            this.ProductCode = productCode;
            this.ProcutName = productName;
            this.Price = price;
        }

        public double SetKdv()
        {
            return this.Price * 1.18;
        }

    }
}
