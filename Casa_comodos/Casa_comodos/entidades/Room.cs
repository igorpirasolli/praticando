﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_comodos.entidades
{
    internal class Room
    {
        public string Type { get; set; }

        public Room(string type)
        {
            Type = type;
        }
    }
}
