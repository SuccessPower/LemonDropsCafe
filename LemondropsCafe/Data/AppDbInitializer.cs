using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using LemondropsCafe.Models;
using System;
using LemondropsCafe.Data.Enum;

namespace LemondropsCafe.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // Menu
                if (!context.Menus.Any())
                {
                    context.Menus.AddRange(
                        new Menu { Name = "Hot Drinks" },
                        new Menu { Name = "Food" },
                        new Menu { Name = "Cold Drinks" }
                    );

                    context.SaveChanges();
                }

                // MenuItem
                if (!context.MenuItems.Any())
                {
                    // Assume you have some sample menu items for each section
                    var hotDrinksMenu = context.Menus.Single(m => m.Name == "Hot Drinks");
                    context.MenuItems.AddRange(
                        new MenuItem { Name = "Coffee", Price = 1000M, Section = MenuSection.HotDrinks, MenuId = hotDrinksMenu.MenuId },
                        new MenuItem { Name = "Tea", Price = 2000M, Section = MenuSection.HotDrinks, MenuId = hotDrinksMenu.MenuId }
                        // Add more menu items as needed
                    );

                    var foodMenu = context.Menus.Single(m => m.Name == "Food");
                    context.MenuItems.AddRange(
                        new MenuItem { Name = "Sandwich", Price = 5000M, Section = MenuSection.Food, MenuId = foodMenu.MenuId },
                        new MenuItem { Name = "Salad", Price = 4500M, Section = MenuSection.Food, MenuId = foodMenu.MenuId }
                        // Add more menu items as needed
                    );

                    var coldDrinksMenu = context.Menus.Single(m => m.Name == "Cold Drinks");
                    context.MenuItems.AddRange(
                        new MenuItem { Name = "Water", Price = 1500M, Section = MenuSection.ColdDrinks, MenuId = coldDrinksMenu.MenuId },
                        new MenuItem { Name = "Soda", Price = 2000M, Section = MenuSection.ColdDrinks, MenuId = coldDrinksMenu.MenuId }
                        // Add more menu items as needed
                    );

                    context.SaveChanges();
                }

                // User seeding
                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { Name = "John Doe", PhoneNumber = "123-456-7890" },
                        new User { Name = "Jane Smith", PhoneNumber = "987-654-3210" },
                        new User { Name = "Success Imamun", PhoneNumber = "555-555-5555" },
                        new User { Name = "Jennifer Okubike", PhoneNumber = "111-111-1111" }
                        // Add more users as needed
                    );

                    context.SaveChanges();
                }

                // Order seeding
                if (!context.Orders.Any())
                {
                    var users = context.Users.ToList();
                    var menuItems = context.MenuItems.ToList();

                    context.Orders.AddRange(
                        new Order { OrderDate = DateTime.Now, User = users[0] },
                        new Order { OrderDate = DateTime.Now, User = users[1] },
                        new Order { OrderDate = DateTime.Now, User = users[2] },
                        new Order { OrderDate = DateTime.Now, User = users[3] }
                        // Add more orders as needed
                    );

                    context.SaveChanges();
                }

                // OrderMenuItem seeding
                if (!context.OrderMenuItems.Any())
                {
                    var orders = context.Orders.ToList();

                    var coffeeItem = context.MenuItems.Single(m => m.Name == "Coffee");
                    var teaItem = context.MenuItems.Single(m => m.Name == "Tea");
                    var sandwichItem = context.MenuItems.Single(m => m.Name == "Sandwich");

                    context.OrderMenuItems.AddRange(
                        new OrderMenuItem { Order = orders[0], MenuItem = coffeeItem },
                        new OrderMenuItem { Order = orders[0], MenuItem = teaItem },
                        new OrderMenuItem { Order = orders[1], MenuItem = sandwichItem },
                        new OrderMenuItem { Order = orders[2], MenuItem = coffeeItem },
                        new OrderMenuItem { Order = orders[2], MenuItem = teaItem },
                        new OrderMenuItem { Order = orders[3], MenuItem = sandwichItem }
                        // Add more order menu items as needed
                    );

                    context.SaveChanges();
                }
            }
        }
    }
}
