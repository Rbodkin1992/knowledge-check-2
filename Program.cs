using System;
using System.Collections.Generic;
using knowledgeCheck2;

namespace KnowledgeCheck2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add?");
            int numberOfRecords;
            while (!int.TryParse(Console.ReadLine(), out numberOfRecords) || numberOfRecords <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            var recordList = new List<object>(); // List to store records

            for (int i = 0; i < numberOfRecords; i++)
            {
                Console.WriteLine("Enter the type of product (1 for Product, 2 for CatFood):");
                int productType;
                while (!int.TryParse(Console.ReadLine(), out productType) || (productType != 1 && productType != 2))
                {
                    Console.WriteLine("Invalid product type. Please enter 1 or 2:");
                }

                if (productType == 1)
                {
                    var product = new Product();
                    Console.WriteLine("Enter Product Name:");
                    product.Name = Console.ReadLine() ?? "Unnamed Product";
                    recordList.Add(product);
                }
                else if (productType == 2)
                {
                    var catFood = new CatFood();
                    Console.WriteLine("Enter CatFood Name:");
                    catFood.Name = Console.ReadLine() ?? "Unnamed CatFood";
                    Console.WriteLine("Enter CatFood Flavor:");
                    catFood.Flavor = Console.ReadLine() ?? "Unknown Flavor";
                    recordList.Add(catFood);
                }
            }

            Console.WriteLine("\nHere are your records:");
            foreach (var record in recordList)
            {
                if (record is CatFood catFood)
                {
                    Console.WriteLine($"CatFood Name: {catFood.Name}, Flavor: {catFood.Flavor}");
                }
                else if (record is Product product)
                {
                    Console.WriteLine($"Product Name: {product.Name}");
                }
            }
        }
    }
}