using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIServer.Controllers
{

    [ApiController]
    [Route("api/Pokemon")]
    public class PokemonController: ControllerBase
    {

        static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Snorlax"},
            new Pokemon() {Name = "Digglet"}
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }
        
    }
}
