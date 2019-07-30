using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LanchoneteMutant.Controllers
{
    public class DominiosController : ApiController
    {
        static readonly Domain.Servicos.Lanches repositorio = new Domain.Servicos.Lanches();

        [HttpGet]
        [Route("api/GetAllDominio")]
        public IEnumerable<Dominios> GetAllDominio()
        {
            return repositorio.GetAllDominio();
        }
    }
}