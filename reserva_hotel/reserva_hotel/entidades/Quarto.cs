using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reserva_hotel.entidades
{
    internal class Quarto
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();

        public Quarto(int numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public void Reservar(string cliente, DateTime data)
        {
            Reservas.Add(new Reserva(data, cliente));
        }
    }
}
