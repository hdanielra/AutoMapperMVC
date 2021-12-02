using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperMVC.Models
{
    public class Beer
    {
        public string Name { get; set; }
        public int Alcohol { get; set; }

        public decimal Price { get; set; }

        public int IdCatgoria { get; set; }
    }
}
