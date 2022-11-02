using PurchaseManagementSystem.Models;
using System;
using System.Linq;

namespace PurchaseManagementSystem.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ItemContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Items.Any())
            {
                return;   // DB has been seeded
            }



            var items = new Item[]
            {
            new Item{ItemName="Mouse", Availability=Availability.Out_Of_Stock, Price= 200},
            new Item{ItemName="Keyboar", Availability = Availability.In_Stock,Price = 100},

            };
            foreach (Item i in items)
            {
                context.Items.Add(i);
            }
            context.SaveChanges();
        }
    }
}