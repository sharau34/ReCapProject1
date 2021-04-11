﻿using Business.Concrete;
using DataAccess.EntityFramework;
using DataAccess.InMemoryConcrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // UserAdd();

            // CustomerAdd();

            // RentAdd();


        }

        private static void RentAdd()
        {
            RentalsManager rentalsManager = new RentalsManager(new EfRentalsDal());
            var resultAdd = rentalsManager.Add(new Rentals { Id = 3, CarId = 3, CustomerId = 3, RentDate = DateTime.Now, ReturnDate = null });
            Console.WriteLine(resultAdd.Message);
        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var resultAdd = customerManager.Add(new Customer { UserId = 1, CustomerId = 1, CompanyName = "İsimsiz holding" });
            Console.WriteLine(resultAdd.Message);
            //foreach (var customer in customerManager.GetAll().Data)
            //{
            //    Console.WriteLine(customer.CompanyName);
            //}
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var resultAdd = userManager.Add(new User { Id = 5, Email = "yusuf10901@hotmail.com", Password = 1234, FirstName = "Yusuf", LastName = "Çırak" });
            var resultAdd2 = userManager.Add(new User { Id = 6, Email = "yusuf10902@hotmail.com", Password = 12345, FirstName = "Yusuff", LastName = "Çırakk" });
            Console.WriteLine(resultAdd.Message);
        }
    }
}
