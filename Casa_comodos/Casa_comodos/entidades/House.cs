using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_comodos.entidades
{
    internal class House
    {
        public List<Room> Rooms { get; set; }

        public House()
        {
            Rooms = new List<Room>
            {
                new Room("sala"),
                new Room ("quarto"),
                new Room ("cozinha")
            };
        }

        public void ListarRooms()
        {
            foreach (Room room in Rooms)
            {
                Console.WriteLine($"Room: {room.Type}");
            }
        }
    }
}
