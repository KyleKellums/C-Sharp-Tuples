using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("hammer", 19.99, 10));
            transactions.Add(("screwdriver", 11.99, 25));
            transactions.Add(("power drill", 109.99, 7));
            transactions.Add(("pliers", 8.99, 12));
            transactions.Add(("pipe wrench", 12.99, 8));

            double totalProducts = 0;
            double totalRevenue = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                totalProducts += t.quantity;
                totalRevenue += t.amount;
            }
                Console.WriteLine($"Items sold today {totalProducts}");
                Console.WriteLine($"Total revenue: {totalProducts * totalRevenue}");
        }
    }
}
