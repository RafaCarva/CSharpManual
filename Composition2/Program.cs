using System;
using System.Globalization;
using Composition2.Entities;
using Composition2.Entities.Enums;

namespace Composition2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            //Attention: The order is month, day and year
            Console.Write("Birth date (MM/DD/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status (PendingPayment, Processing, Shipped, Delivered): ");
            OrderStatus orderStatus = new OrderStatus();
            Enum.TryParse(Console.ReadLine(), out orderStatus);

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, orderStatus, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}
/*
Enter client data:
Name: rafa
Email: rafa@gmail.com
Birth date (MM/DD/YYYY): 10/12/1999
Enter order data: 
Status (PendingPayment, Processing, Shipped, Delivered): Delivered
How many items to this order? 2
Enter #1 item data:
Product name: cabo
Product price: 234.45
Quantity: 3
Enter #2 item data:
Product name: TV
Product price: 4000.00
Quantity: 2

ORDER SUMMARY:
Order moment: 14/06/2019 09:40:00
Order status: Delivered
Client: rafa, (12/10/1999) - rafa@gmail.com
Order items:
cabo, $234.45, Quantity: 3, Subtotal: $703.35
TV, $4000.00, Quantity: 2, Subtotal: $8000.00
Total price: $8703.35
*/