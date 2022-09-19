using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOrder.Entities
{
    internal class OrderItem
    {
        Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = product.Price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: " 
                + Quantity 
                + ", Subtotal: $" 
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
