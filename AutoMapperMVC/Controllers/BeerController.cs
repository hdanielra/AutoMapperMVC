using AutoMapper;
using AutoMapperMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        // creo un objeto para mapear
        private readonly IMapper _mapper;

        public BeerController(IMapper mapper)
        {
            // inicializo el objeto de mapeo usando el constructor
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult Add(BeerRequest request)
        {

            // mapear automáticamente los campos usando el objeto _mapper
            // el destino será beer y el origen será request
            
            Beer beer =_mapper.Map<Beer>(request);
            return Ok();
        }
    }
}
