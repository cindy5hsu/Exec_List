using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_List
{
    //宣告一個 List<Product> 變數, 存放多筆購買商品
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> lst = new List<Product>
            {
                new Product{ ProductID =1, ProductName="Clothes"},
                new Product{ProductID =2, ProductName="pants"},
                new Product{ProductID =3, ProductName="socks"},
            };


           
            foreach (var arg in lst)
            {
                Console.WriteLine($"{arg.ProductID},{arg.ProductName}");
            }



        }
        class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }

            public override string ToString()
            {
                return "ID: " + ProductID + "Name" + ProductName;
            }
           
        }

    }
}

