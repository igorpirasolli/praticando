using pedido.entidades.Enun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedido.entidades
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Cliente Cliente { get; set; }

        public Order()
        {
        }

        public Order(OrderStatus status, Cliente cliente)
        {
            
            Status = status;
            Cliente = cliente;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double total()
        {
            return Items.Sum(x => x.subTotal());

        }

        public void imprimir()
        {
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine($"Order moment: {DateTime.Now}");
            Console.WriteLine($"enter order status: {Status}");
            Console.WriteLine($"Cliente: {Cliente.Name} {Cliente.BirthDate.ToString("dd/MM/yyyy")} - {Cliente.Email}");
            Console.WriteLine("Order itens: ");
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Product.Name}, {item.Price:c}, Quantity: {item.Quantity}, Subtotal: {item.subTotal():c}");
            }
            Console.WriteLine($"Total price: {total():c}");
        }
    }
}
