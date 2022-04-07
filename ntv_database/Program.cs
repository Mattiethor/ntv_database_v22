using ntv_database.Migrations;
using ntv_database.Models;
using System;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Program");

            CompanyContext.SeedDatabase();

            List<string> test = new List<string>();
            test.Add("Hello");

           using(var db = new CompanyContext())
            {
                var sale = db.Sales.Where(s => s.Id == 1).FirstOrDefault();
                sale.ItemOrders.Add(new ItemOrder { Item = db.Items.Where(i => i.Id == 2).FirstOrDefault(), Quantity = 10 });
                db.SaveChanges();
                    
            }

 
                Console.WriteLine("Ending program");

        }
    }
}