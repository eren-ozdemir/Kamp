using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public float Price { get; set; }
        public float DiscountedPrice { get; set; }
        public int Sales { get; set; }
    }   
}
