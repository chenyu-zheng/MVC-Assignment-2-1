namespace Assignment_2_1.Migrations
{
    using Assignment_2_1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment_2_1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assignment_2_1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            Product product = null;
            if (!context.Products.Any(p => p.Name == "Sample Product"))
            {
                product = new Product()
                {
                    Name = "Sample Product",
                    Quantity = 10,
                    Price = 29.99M,
                };
                context.Products.Add(product);
            }

            context.SaveChanges();

            Customer customer = null;
            if (!context.Customers.Any(c => c.Name == "Dummy Customer"))
            {
                customer = new Customer()
                {
                    Name = "Dummy Customer",
                    Email = "customer@somewhere.com"
                };
                context.Customers.Add(customer);
            }

            context.SaveChanges();

            Employee employee = null;
            if (!context.Employees.Any(e => e.Name == "Dummy Employee"))
            {
                employee = new Employee()
                {
                    Name = "Dummy Employee",
                    RegistrationNumber = 100001
                };
                context.Employees.Add(employee);
            }

            context.SaveChanges();

            StoreLocation store = null;
            if (!context.StoreLocations.Any(s => s.LocationName == "Deserted Store"))
            {
                store = new StoreLocation()
                {
                    LocationName = "Deserted Store"
                };
                context.StoreLocations.Add(store);
            }

            context.SaveChanges();

            Sale sale = null;
            if (!context.Sales.Any())
            {
                sale = new Sale()
                {
                    Date = DateTimeOffset.Now
                };
                sale.Customer = context.Customers.FirstOrDefault(c => c.Name == "Dummy Customer");
                sale.Employee = context.Employees.FirstOrDefault(e => e.RegistrationNumber == 100001);
                sale.StoreLocation = context.StoreLocations.FirstOrDefault(e => e.LocationName == "Deserted Store");
                sale.Products.Add(context.Products.FirstOrDefault(p => p.Name == "Sample Product"));

                context.Sales.Add(sale);
            }

            context.SaveChanges();
        }
    }
}
