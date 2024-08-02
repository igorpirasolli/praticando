using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reserva_hotel.entidades
{
    internal class Reserva
    {
        public DateTime Data { get; set; }
        public string Cliente { get; set; }

        public Reserva(DateTime data, string cliente)
        {
            Data = data;
            Cliente = cliente;
        }

        public void ExibirReserva()
        {
            Console.WriteLine($"Cliente: {Cliente}, data: {Data.ToShortDateString()}");
        }
    }
}
