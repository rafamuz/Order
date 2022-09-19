using ExerciseOrder.Entities;
using ExerciseOrder.Entities.Enums;
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int itemsQty = int.Parse(Console.ReadLine());

            for(int i = 1; i <= itemsQty; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productName, productPrice);
                Console.Write("Quantity: ");
                int itemQty = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(product, itemQty);
                order.AddItem(orderItem);
            }

            Console.WriteLine();             
            Console.WriteLine(order.ToString());
            Console.ReadLine();

        }
    }
}
