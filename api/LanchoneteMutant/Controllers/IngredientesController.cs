using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LanchoneteMutant.Controllers
{
    public class IngredientesController : ApiController
    {
        static readonly Domain.Servicos.Lanches repositorio = new Domain.Servicos.Lanches();

        [HttpGet]
        [Route("api/GetAllIngrediente")]
        public IEnumerable<Ingredientes> GetAllIngrediente()
        {
            return repositorio.GetAllIngrediente();
        }
    }
}