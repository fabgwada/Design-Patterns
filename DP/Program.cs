#define RIP
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DP
{
    class Program
    {
#if RIP
        static Dictionary<int, Customer> Customers;
        static void Main(string[] args)
        {
            Customers = new Dictionary<int, Customer>();
            Customers.Add(1, new Lead());
            Customers.Add(2, new Buyer());

            int custIndex = 0;

            while (true)
            {
                Console.WriteLine("Build a Lead (1), or build a Buyer (2), type 1 or 2");
                var entry = Console.ReadLine();
                Debug.WriteLine($"le type choisi est {entry}");

                if (entry == "1" || entry == "2")
                {
                    custIndex = int.Parse(entry);
                    break;
                }
            }

            var customer = Customers.GetValueOrDefault(custIndex);

            Console.WriteLine(customer.GetType());
            Console.Read();
        }
    }
#endif
}
