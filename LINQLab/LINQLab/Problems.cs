﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LINQLab.Models;
using System.Collections.Generic;
using System.Data;

namespace LINQLab
{
    class Problems
    {
        private EcommerceContext _context;

        public Problems()
        {
            _context = new EcommerceContext();
        }
        public void RunLINQQueries()
        {
            //// <><><><><><><><> R Actions (Read) <><><><><><><><><>
            //RDemoOne();
            //RProblemOne();
            //RDemoTwo();
            //RProblemTwo();
            //RProblemThree();
            //RProblemFour();
            //RProblemFive();

            //// <><><><><><><><> R Actions (Read) with Foreign Keys <><><><><><><><><>
            //RDemoThree();
            //RProblemSix();
            //RProblemSeven();
            //RProblemEight();

            //// <><><><><><><><> CUD (Create, Update, Delete) Actions <><><><><><><><><>

            //// <><> C Actions (Create) <><>
            //CDemoOne();
            //CProblemOne();
            //CDemoTwo();
            //CProblemTwo();

            //// <><> U Actions (Update) <><>
            //UDemoOne();
            //UProblemOne();
            //UProblemTwo();

            //// <><> D Actions (Delete) <><>
            //DDemoOne();
            //DProblemOne();
            //DProblemTwo();

            //// <><> Bonus Actions <><>
            BonusOne();
        }

        // <><><><><><><><> R Actions (Read) <><><><><><><><><>
        private void RDemoOne()
        {
            // This LINQ query will return all the users from the User table.
            var users = _context.Users.ToList();

            Console.WriteLine("RDemoOne: Emails of All users");
            foreach (User user in users)
            {
                Console.WriteLine(user.Email);
            }

        }

        private void RProblemOne()
        {
            // Print the COUNT of all the users from the User table.
            var usersCount = _context.Users.Count();
            Console.WriteLine("Number of Users:\n{0}", usersCount);
        }

        public void RDemoTwo()
        {
            // This LINQ query will get each product whose price is greater than $150.
            var productsOver150 = _context.Products.Where(p => p.Price > 150);
            Console.WriteLine("RDemoTwo: Products greater than $150");
            foreach (Product product in productsOver150)
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }
        }

        public void RProblemTwo()
        {
            // Write a LINQ query that gets each product whose price is less than or equal to $100.
            // Print the name and price of all products
            var productsUnder100 = _context.Products.Where(p => p.Price <= 100);
            Console.WriteLine("Products less than $100:");
            foreach (Product product in productsUnder100)
            {
                Console.WriteLine("{0} - {1}", product.Name, product.Price);
            }
        }

        public void RProblemThree()
        {
            // Write a LINQ query that gets each product whose name that CONTAINS an "s".
            var productsWithS = _context.Products.Where(p => p.Name.Contains("s"));
            Console.WriteLine("Products whose name contains an 's':");
            foreach (Product product in productsWithS)
            {
                Console.WriteLine(product.Name);
            }
        }

        public void RProblemFour()
        {
            // Write a LINQ query that gets all the users who registered BEFORE 2016.
            // Then print each user's email and registration date to the console.
            var longTimeUsers = _context.Users.Where(u => u.RegistrationDate < new DateTime(2016,1,1));
            foreach (User user in longTimeUsers)
            {
                Console.WriteLine("Email: {0}\nRegistration Date: {1}", user.Email, user.RegistrationDate);
            }
        }

        public void RProblemFive()
        {
            // Write a LINQ query that gets all of the users who registered AFTER 2016 and BEFORE 2018.
            // Then print each user's email and registration date to the console.
            var usersBetween20162018 = _context.Users.Where(u => u.RegistrationDate > new DateTime(2016, 12, 31) && u.RegistrationDate < new DateTime(2018, 1, 1));
            foreach (User user in usersBetween20162018)
            {
                Console.WriteLine("Email: {0}\nRegistration Date: {1}", user.Email, user.RegistrationDate);
            }
        }


        // <><><><><><><><> R Actions (Read) with Foreign Keys <><><><><><><><><>

        private void RDemoThree()
        {
            // This LINQ query will retreive all of the users who are assigned to the role of Customer.
            var customerUsers = _context.Userroles.Include(ur => ur.Role).Include(ur => ur.User).Where(ur => ur.Role.RoleName == "Customer");
            Console.WriteLine("RDemoThree: Customer Users");
            foreach (Userrole userrole in customerUsers)
            {
                Console.WriteLine($"Email: {userrole.User.Email} Role: {userrole.Role.RoleName}");
            }
        }
        public void RProblemSix()
        {
            // Write a LINQ query that retrieves all of the products in the shopping cart of the user who has the email "afton@gmail.com".
            // Then print the product's name, price, and quantity to the console.
            var aftonsProducts = _context.Shoppingcarts.Include(sc => sc.Product).Include(sc => sc.User).Where(sc => sc.User.Email == "afton@gmail.com");
            foreach (var items in aftonsProducts)
            {
                Console.WriteLine(items.Product.Name);
            }
        }

        public void RProblemSeven()
        {
            // Write a LINQ query that retrieves all of the products in the shopping cart of the user who has the email "oda@gmail.com" and returns the sum of all of the products prices.
            // HINT: End of query will be: .Select(sc => sc.Product.Price).Sum();
            // Print the total of the shopping cart to the console.
            // Remember to break the problem down and take it one step at a time!
            var odaProductsTotal = _context.Shoppingcarts.Include(sc => sc.Product).Include(sc => sc.User).Where(sc => sc.User.Email == "oda@gmail.com").Select(sc => sc.Product.Price).Sum(); // .Sum(sc => sc.Product.Price)
            Console.WriteLine(odaProductsTotal);
        }

        public void RProblemEight()
        {
            // Write a query that retrieves all of the products in the shopping cart of users who have the role of "Employee".
            // Then print the product's name, price, and quantity to the console along with the email of the user that has it in their cart.
            var employeeProducts = _context.Shoppingcarts.Include(sc => sc.Product).Include(sc => sc.User)
                .Where(sc => _context.Userroles.Any(ur => ur.User == ur.User && ur.Role.RoleName == "Employee"));
            foreach (var item in employeeProducts)
            {
                Console.WriteLine("User:{3}\nProduct:\nName: {0} Price: {1} Quantity: {2}", item.Product.Name, item.Product.Price, item.Quantity, item.User.Email);
            }
        }


        // <><><><><><><><> CUD (Create, Update, Delete) Actions <><><><><><><><><>

        //IMPORTANT: The following methods will MODIFY your database. Even if you stop and restart the application, any changes made to the database will persist!
        //Calling a Create method more than once will result in duplicate data added to the table.
        //Calling an Update or Delete method more than once might cause an error. For instance, if you call a method that deletes the Nintendo Switch from the database, then try to call the method again, there will no longer be a Nintendo Switch to delete!
        //You may want to use Breakpoints or WriteLines to verify your LINQ Queries are finding the correct items before you add the .SaveChanges() to the method!

        // <><> C Actions (Create) <><>

        private void CDemoOne()
        {
            // This will create a new User object and add it to the Users table.
            User newUser = new User()
            {
                Email = "david@gmail.com",
                Password = "DavidsPass123"
            };
            _context.Users.Add(newUser);
            _context.SaveChanges();

        }

        private void CProblemOne()
        {
            // Create a new Product object and add that product to the Products table. Choose any name and product info you like.
            Product newProduct = new Product()
            {
                Name = "Valve Steam Deck",
                Description = "Handheld computer to play your video games on.",
                Price = 500
            };
            _context.Products.Add(newProduct);
            _context.SaveChanges();
        }

        public void CDemoTwo()
        {
            // This will add the role of "Customer" to the user we created in CDemoOne by adding a new row to the Userroles junction table.
            var roleId = _context.Roles.Where(r => r.RoleName == "Customer").Select(r => r.Id).SingleOrDefault();
            var userId = _context.Users.Where(u => u.Email == "david@gmail.com").Select(u => u.Id).SingleOrDefault();
            Userrole newUserrole = new Userrole()
            {
                UserId = userId,
                RoleId = roleId
            };
            _context.Userroles.Add(newUserrole);
            _context.SaveChanges();
            // If you encounter problems running this method, it likely means you ran CDemoOne multiple times and have created duplicate customers with the email "david@gmail.com"
        }

        public void CProblemTwo()
        {
            // Create a new ShoppingCartItem to represent the new product you created in CProblemOne being added to the shopping cart of the user created in CDemoOne.
            // This will add a new row to ShoppingCart junction table.
            var userId = _context.Users.Where(u => u.Email == "david@gmail.com").Select(u => u.Id).SingleOrDefault();
            var productId = _context.Products.Where(p => p.Name == "Valve Steam Deck").Select(p => p.Id).SingleOrDefault();
            Shoppingcart newShoppingCart = new Shoppingcart()
            {
                UserId = userId,
                ProductId = productId,
                Quantity = 1
            };
            _context.Shoppingcarts.Add(newShoppingCart);
            _context.SaveChanges();
        }


        // <><> U Actions (Update) <><>

        private void UDemoOne()
        {
            // This will update the email of the user from CDemoOne to "dan@gmail.com"
            // Remember that after this update occurs, there should be no more "david@gmail.com" on the database!
            var user = _context.Users.Where(u => u.Email == "david@gmail.com").SingleOrDefault();
            user.Email = "dan@gmail.com";
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        private void UProblemOne()
        {
            // Update the price of the product you created in CProblemOne to something different using LINQ.
            var product = _context.Products.Where(p => p.Name == "Valve Steam Deck").SingleOrDefault();
            product.Price = 450;
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        private void UProblemTwo()
        {
            // Change the role of the user we created to "Employee"
            // HINT: You need to delete the existing role relationship and then create a new Userrole object and add it to the Userroles table
            // See the DDemoOne below as an example of removing a role relationship
            var userRole = _context.Userroles.Where(ur => ur.User.Email == "dan@gmail.com").SingleOrDefault();
            _context.Userroles.Remove(userRole);
            _context.SaveChanges();
            var roleId = _context.Roles.Where(r => r.RoleName == "Employee").Select(r => r.Id).SingleOrDefault();
            var userId = _context.Users.Where(u => u.Email == "dan@gmail.com").Select(u => u.Id).SingleOrDefault();
            Userrole newUserrole = new Userrole()
            {
                UserId = userId,
                RoleId = roleId
            };
            _context.Userroles.Add(newUserrole);
            _context.SaveChanges();
        }

        // <><> D Actions (Delete) <><>

        private void DDemoOne()
        {
            // Delete the role relationship from the user who has the email "oda@gmail.com" using LINQ.
            var userrole = _context.Userroles.Where(ur => ur.User.Email == "oda@gmail.com").SingleOrDefault();
            _context.Userroles.Remove(userrole);

            _context.SaveChanges();

        }

        private void DProblemOne()
        {
            // Delete all of the product relationships to the user with the email "oda@gmail.com" in the ShoppingCart table using LINQ.
            // HINT: Use a Loop
            var shoppingcart = _context.Shoppingcarts.Where(sc => sc.User.Email == "oda@gmail.com").ToList();
            foreach (var item in shoppingcart)
            {
                _context.Shoppingcarts.Remove(item);
                _context.SaveChanges();
            }

        }

        private void DProblemTwo()
        {
            // Delete the user with the email "oda@gmail.com" from the Users table using LINQ.
            var user = _context.Users.Where(u => u.Email == "oda@gmail.com").SingleOrDefault();
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        // <><><><><><><><> BONUS PROBLEMS <><><><><><><><><>

        private void BonusOne()
        {
            // Prompt the user to enter in an email and password through the console.
            // Take the email and password and check if the there is a person that matches that combination.
            // Print "Signed In!" to the console if they exists and the values match otherwise print "Invalid Email or Password.".
            Console.WriteLine("Enter Email: ");
            string userEmail = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string userPassword = Console.ReadLine();
            var user = _context.Users.Where(u => u.Email == userEmail && u.Password == userPassword).SingleOrDefault();
            if (user != null)
            {
                Console.WriteLine("Signed In!");
            }
            else
            {
                Console.WriteLine("Invalid Email or Password.");
            }
        }

        private void BonusTwo()
        {
            // Write a query that finds the total of every users shopping cart products using LINQ.
            // Display the total of each users shopping cart as well as the total of the toals to the console.
        }

        // BIG ONE
        private void BonusThree()
        {
            // 1. Create functionality for a user to sign in via the console
            // 2. If the user succesfully signs in, give them a menu where they can perform the following actions within the console:
            // -View the products in their shopping cart
            // -View all products in the Products table
            // -Add a product to the shopping cart (incrementing quantity if that product is already in their shopping cart)
            // -Remove a product from their shopping cart
            // 3. If the user does not successfully sign in
            // -Display "Invalid Email or Password"
            // -Re-prompt the user for credentials

        }

    }
}
