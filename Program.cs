﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}

    public class Program
    {
        public static void Main() {
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            // var millionaires = from cust in customers 
            //     where cust.Balance >= 1000000
            //     select cust;

            // foreach (var cust in millionaires)
            // {
            //     Console.WriteLine($"{cust.Name} ${cust.Balance}");
            // }

            // var grouped = from cust in customers 
            //     where cust.Balance >= 1000000
            //     group cust by cust.Bank into taco
            //     select new {Bank = taco.Key, Customers = taco};

            var grouped = customers.Where(c => c.Balance >= 1000000)
                                   .GroupBy(d => d.Bank);

            foreach (var pizza in grouped)
            {
                Console.WriteLine($"{pizza.Key} {pizza.Count()}");
                
                foreach (var customer in pizza)
                {
                    Console.WriteLine($"  {customer.Name} {customer.Balance}");
                }

            }

        }

    }
}

