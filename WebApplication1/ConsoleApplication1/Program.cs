using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ProductList = new List<Product>();
            Product pd = new Product();
            pd.Name = "棉衣";
            pd.Price = 69;
            ProductList.Add(pd);

            pd = new Product();
            pd.Name = "鞋子";
            pd.Price = 199;
            ProductList.Add(pd);

            foreach (var item in ProductList)
            {
                Console.WriteLine("Name:{0},Price:{1}", item.Name, item.Price);
            }
            Console.ReadKey();
        }
    }
}
