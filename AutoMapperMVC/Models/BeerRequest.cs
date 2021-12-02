using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperMVC.Models
{
    public class BeerRequest
    {
        // cuando los nombre de los campos son iguales el mapper es automático
        //public string Name { get; set; }


        // pero cuando algún nombre es diferente al de la otra clase hay que mapearlo
        public string Nombre { get; set; }
        public int Alcohol { get; set; }
        public decimal Precio { get; set; }
    }
}
