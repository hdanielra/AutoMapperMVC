using AutoMapper;
using AutoMapperMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperMVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // si los nombres entre las clases son iguales, se pueden mapear las 2 clases así: 
            // CreateMap<BeerRequest, Beer>();



            // pero si algún campo tiene nombre diferente
            // en este caso en un lado se llama Name y en el otro Nombre
            // con la siguiente instrucción se mapean



            _ = CreateMap<BeerRequest, Beer>()
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Nombre))
                .ForMember(d => d.Price, o => o.MapFrom(s => s.Precio));




            // FormMember: cómo será la interacción entre el mapeo de campos:
            //  - d: destino
            //  - o: origen
            //  - s: source

            // como no nos interesa el resultado retornado de la función CreateMap(origen, destino),
            // lo asignamos a una variable temporal
            // esta variable temporal en C# se le denomina "descarte" y se representa con _
            // you can use discards to specify unused input parameters of a lambda expression


            // en c# el operador => se conoce como operador lambda.
            // sirve para crear un Func<>, Action<> o Expression<Func<>> según se necesite

            // The => token is supported in two forms: as the lambda operator and as a separator of a member name and the member implementation in an expression body definition.

        }
    }
}
