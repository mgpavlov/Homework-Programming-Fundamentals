using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ProductQuantity { get; set; }
            public decimal Bill { get; set; }
        }
        static void Main(string[] args)
        {
            var productPrice = new Dictionary<string, decimal>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var lineProductsPrices = Console.ReadLine();
                var tokens = lineProductsPrices.Split('-').ToList();

                if (!productPrice.ContainsKey(tokens[0]))
                {
                    productPrice.Add(tokens[0], decimal.Parse(tokens[1]));
                }
                else
                {
                    productPrice[tokens[0]] = decimal.Parse(tokens[1]);
                }
            }
            var lineCustomerBill = Console.ReadLine();
            var customerList = new List<Customer>();
            while (lineCustomerBill != "end of clients")
            {
                var tokenss = lineCustomerBill.Split(new char[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string name = tokenss[0];
                string product = tokenss[1];
                int quantity = int.Parse(tokenss[2]);

                if (productPrice.ContainsKey(product))
                {
                    if (customerList.Any(x=>x.Name == name))
                    {
                        var customerProductQuantity = new Dictionary<string, int>();
                        var currentCustomer = customerList.FirstOrDefault(x => x.Name == name);

                        if (!currentCustomer.ProductQuantity.ContainsKey(product))
                        {
                            currentCustomer.ProductQuantity.Add(product, quantity);
                        }
                        else
                        {
                            currentCustomer.ProductQuantity[product] += quantity;
                        }
                    }
                    else
                    {
                        Customer customer = new Customer();
                        customer.ProductQuantity = new Dictionary<string, int>();
                        customer.Name = name;
                        customer.ProductQuantity.Add(product, quantity);
                        customerList.Add(customer);
                    }
                }

                lineCustomerBill = Console.ReadLine();
            }

            foreach (var customer in customerList)
            {

                foreach (var product in customer.ProductQuantity)
                {
                    customer.Bill += product.Value * productPrice[product.Key];
                }
            }
            
            var printList = customerList.OrderBy(name => name.Name).ToList();
            foreach (var customer in printList)
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.ProductQuantity)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }

            var totalBill = customerList.Sum(b => b.Bill);
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
