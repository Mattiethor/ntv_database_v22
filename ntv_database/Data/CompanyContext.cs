using Microsoft.EntityFrameworkCore;
using ntv_database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntv_database.Migrations
{
    public class CompanyContext : DbContext
    {
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ItemOrder> ItemsOrders { get; set; }


        public string DbPath { get; }

        public CompanyContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Company.db");
        }

        public static void SeedDatabase()
        {
            using (var db = new CompanyContext())
            {
                
                db.Database.EnsureCreated();
                Console.WriteLine("Seeding Database");

                //created object of the Models to use in seeding.
                Customer c1 = new Customer() { Name = "Big Company", Address = "Company Street 111" };
                Employee e1 = new Employee() { FirstName = "Mr", LastName = "Admin", Position = "Clerk" };
                Item i1 = new Item() { ItemName = "widgit small", UnitPrice = 60 };
                Item i2 = new Item() { ItemName = "Screws", UnitPrice = 200 };
                Item i3 = new Item() { ItemName = "Hammers", UnitPrice = 400 };
                
            
                
              


                //Seeding Customer table
                var c1_exist = db.Customers.FirstOrDefault(c => c.Name == c1.Name);
                if (c1_exist == null)
                {
                    db.Add(c1);
                    db.SaveChanges();
                }

           

                //Seeding Employee table
                var e1_exist = db.Employees.FirstOrDefault(c => c.FirstName == "Mr" && c.LastName == "Admin");
                if (e1_exist == null)
                {
                    
                    db.Add(e1);
                    db.SaveChanges();
                }

                   
                //Seeding Item table
                var i1_exist = db.Items.FirstOrDefault(i => i.ItemName == "widgit small");
                if (i1_exist == null)
                {
                    
                    db.Add(i1);
                    db.SaveChanges();
                }
                
              var i2_exist = db.Items.FirstOrDefault(i => i.ItemName == "Screws");
              if (i2_exist == null)
              {
                 
                  db.Add(i2);
                  db.SaveChanges();
              }
                

                var i3_exist = db.Items.FirstOrDefault(i => i.ItemName == "Hammers");
                if (i3_exist == null)
                {
                   
                    db.Add(i3);
                    db.SaveChanges();
                }

                
                
                var s1_exists = db.Sales.FirstOrDefault(s => s.Id == 1);
                if (s1_exists == null)
                {
                    Sale s1 = new Sale();
                    
                    s1.Customer = c1;
                    s1.Employee = e1;

                    s1.ItemOrders.Add(new ItemOrder {Item = i1, Quantity = 40 });

                    db.Add(s1);
                    db.SaveChanges();
                }
                

                
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Companydb");
        }

    }
    }


