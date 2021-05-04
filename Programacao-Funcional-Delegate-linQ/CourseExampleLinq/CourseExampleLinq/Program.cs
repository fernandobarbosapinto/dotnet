using System;
using Course.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CourseExampleLinq
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Qualification = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Qualification = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Qualification = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() {Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() {Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product() {Id = 3, Name = "TV", Price = 1700.0, Category = c3},
                new Product() {Id = 4, Name = "Nootbook", Price = 1300.0, Category = c2},
                new Product() {Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product() {Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product() {Id = 7, Name = "Camera", Price = 750.0, Category = c3},
                new Product() {Id = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product() {Id = 9, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product() {Id = 10, Name = "Sound Bar", Price = 710.0, Category = c3},
                new Product() {Id = 11, Name = "Level", Price = 60.0, Category = c1},
            };

            var r1 = products.Where(p => p.Category.Qualification == 1 && p.Price < 900.0);

           Print("Qualification 1 and price < 900: ", r1);
        }
    }
}
