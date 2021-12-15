using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2GunODevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 101;
            product1.CategoryId = 3;
            product1.StockQuantity = 300;
            product1.ProductPrice = 4;
            product1.ProductName = "Kırmızı Elma";
            product1.ProductDescription = "Tatlı Elma";

            Product product2 = new Product();
            product2.Id = 102;
            product2.CategoryId = 3;
            product2.StockQuantity = 200;
            product2.ProductPrice = 5;
            product2.ProductName = "Yeşil Elma";
            product2.ProductDescription = "Ekşi Elma";

            Product product3 = new Product();
            product3.Id = 201;
            product3.CategoryId = 2;
            product3.StockQuantity = 500;
            product3.ProductPrice = 3;
            product3.ProductName = "Patates";
            product3.ProductDescription = "Kızartmalık patates";

            Product product4 = new Product();
            product4.Id = 301;
            product4.CategoryId = 6;
            product4.StockQuantity = 50;
            product4.ProductPrice = 250;
            product4.ProductName = "Çalışma Masası";
            product4.ProductDescription = "Beyaz Kaplamalı";

            Product product5 = new Product();
            product5.Id = 302;
            product5.CategoryId = 6;
            product5.StockQuantity = 50;
            product5.ProductPrice = 250;
            product5.ProductName = "Çalışma Masası";
            product5.ProductDescription = "Ahşap Desenl Kaplamalı";

            Product[] products = new Product[]
                {product1, product2, product3, product4, product5};

            Console.WriteLine("For döngüsü ile sıralama ;");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("--------------");
                Console.WriteLine(products[i].Id);
                Console.WriteLine(products[i].CategoryId);
                Console.WriteLine(products[i].StockQuantity);
                Console.WriteLine(products[i].ProductPrice);
                Console.WriteLine(products[i].ProductName);
                Console.WriteLine(products[i].ProductDescription);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("Foreach döngüsü ile sıralama ;");

            foreach (Product product in products)
            {
                Console.WriteLine("--------------");
                Console.WriteLine(product.Id);
                Console.WriteLine(product.CategoryId);
                Console.WriteLine(product.StockQuantity);
                Console.WriteLine(product.ProductPrice);
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.ProductDescription);
                Console.WriteLine("--------------");
            }


            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("While döngüsü ile sıralama ;");

            int c = 0;
            while (c < products.Length)
            {

                Console.WriteLine("--------------");
                Console.WriteLine(products[c].Id);
                Console.WriteLine(products[c].CategoryId);
                Console.WriteLine(products[c].StockQuantity);
                Console.WriteLine(products[c].ProductPrice);
                Console.WriteLine(products[c].ProductName);
                Console.WriteLine(products[c].ProductDescription);
                Console.WriteLine("--------------");
                c++;

            }



            Console.ReadLine();

        }
    }
}
