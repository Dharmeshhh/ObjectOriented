﻿using System;

namespace ObjectOriented
{
   
    public class ObjectOrientedMain 
    {
        public static void Main()
        {
            ObjectOrientedConcepts o = new ObjectOrientedConcepts("Dharmesh");
            o.PrintName(); //op Dharmesh
            o.NameModificationsRef(ref o.Name);
            o.PrintName(); //op Megatron
            o.NameModificationsOut(out o.Name /*change value of object entity from here so Megatron will be replaced by cybertron inside the function cause we are passing reference as a out argument*/);
            o.PrintName(); //op cybertron
            ref String refName = ref o.RefReturn();
            refName = "Optimus Prime"; // we are changing output copy 
            o.PrintName();
            Console.WriteLine("{0} Age:{1}", refName, ObjectOrientedConcepts.Age());



            //local constant
            const string developerName = "Dharmesh";

            //create reference variables
            Product product1, product2, product3;

            //create objects
            product1 = new Product();
            Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //1
            product2 = new Product();
            Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //2
            product3 = new Product();
            Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //3

            //initalize fields
            product1.SetProductID(1001);
            product1.SetProductName("Mobile");
            product1.SetCost(20000);
            product1.SetQuantityInStock(1200);
            product2.SetProductID(1003);
            product2.SetProductName("Laptop");
            product2.SetCost(45000);
            product2.SetQuantityInStock(3400);
            product3.SetProductID(1003);
            product3.SetProductName("Speakers");
            product3.SetCost(36000);
            product3.SetQuantityInStock(800);

            //call methods
            double q = 9.2;
            product1.CalculateTax(percentage: ref q);

            //ref
            double p = 7.4;
            product2.CalculateTax(ref p);
            System.Console.WriteLine("p is " + p);

            product3.CalculateTax(10000, 3.4);

            //get values from fields
            System.Console.WriteLine(developerName);

            System.Console.WriteLine("Product 1:");
            System.Console.WriteLine("Product ID: " + product1.GetProductID());
            System.Console.WriteLine("Product Name: " + product1.GetProductName());
            System.Console.WriteLine("Cost: " + product1.GetCost());
            System.Console.WriteLine("Quantity in Stock: " + product1.GetQuantityInStock());
            System.Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurchase());
            System.Console.WriteLine("Tax: " + product1.GetTax());

            System.Console.WriteLine("\nProduct 2:");
            System.Console.WriteLine("Product ID: " + product2.GetProductID());
            System.Console.WriteLine("Product Name: " + product2.GetProductName());
            System.Console.WriteLine("Cost: " + product2.GetCost());
            System.Console.WriteLine("Quantity in Stock: " + product2.GetQuantityInStock());
            System.Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
            System.Console.WriteLine("Tax: " + product2.GetTax());

            System.Console.WriteLine("\nProduct 3:");
            System.Console.WriteLine("Product ID: " + product3.GetProductID());
            System.Console.WriteLine("Product Name: " + product3.GetProductName());
            System.Console.WriteLine("Cost: " + product3.GetCost());
            System.Console.WriteLine("Quantity in Stock: " + product3.GetQuantityInStock());
            System.Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
            System.Console.WriteLine("Tax: " + product3.GetTax());

            //total Quantity
            int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);


            //display totals
            System.Console.WriteLine("Total Quantity: " + totalQuantity);
            System.Console.WriteLine("Total no. of products: " + Product.GetTotalNoOfProducts());  //Output: 3
            System.Console.WriteLine("Category of products: " + Product.CategoryName);  //Output: Electronics


            ObjectOrientedConcepts.ParamString("Dharmesh", "Optimus", "Megatron", "Bumble Bee");
            System.Console.ReadKey();

            ObjectOrientedConcepts obj1 = new ObjectOrientedConcepts(1, "Dharmesh777", "A+");
            ObjectOrientedConcepts obj2 = new ObjectOrientedConcepts(2, "Optimus111", "B+");
            ObjectOrientedConcepts obj3 = new ObjectOrientedConcepts(3, "Cybertron333", "C+");

            /*Object Initilizer 
            
             Initialise the overloaded constructor(without parameter) and thn initialise our custom parameters by this syntax
             */
            ObjectOrientedConcepts obj4 = new ObjectOrientedConcepts() {
            studentName="Megatron",
            studentGrade="D+"
            };

            obj1.PrintStudent();
            obj2.PrintStudent();
            obj3.PrintStudent();
            // Object Initilizer instance
            obj4.PrintStudent();



        }
    }
}
