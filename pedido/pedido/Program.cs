using pedido.entidades;
using pedido.entidades.Enun;

namespace pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime bithDate = DateTime.Parse(Console.ReadLine());

            Console.Write("enter order data(PendingPayment / Processing / Shipped / Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Cliente cliente = new Cliente(name, email, bithDate);
            Order order = new Order(status, cliente);

            Console.Write("how many itens to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"enter #{i + 1} item data:");
                Console.Write("product name: ");
                string productName = Console.ReadLine();
                Console.Write("product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(quantity,productPrice, product);
                order.addItem(item);
            }

            order.imprimir();
        }
    }
}