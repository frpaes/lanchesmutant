using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace LanchoneteMutant.Controllers
{

    public class lancheRequest{

        public string codLanche { get; set; }
    }

    public class VendasLanchesController : ApiController
    {
        static readonly Domain.Servicos.Lanches repositorio = new Domain.Servicos.Lanches();

        [HttpGet]
        [Route("api/GetAllVendasLanche")]
        public IEnumerable<VendasLanches> GetAllVendasLanche()
        {
            return repositorio.GetAllVendasLanche();
        }

        [HttpGet]
        [Route("api/PostVendas")]
        public string PostVendas(string codLanche)
        {
            if (!string.IsNullOrEmpty(codLanche))
            {
                repositorio.Add(codLanche, string.Empty);
                return "ok";
            }
            else
                return "false";
        }

        [HttpDelete]
        [Route("api/DeleteVendas/{codVendas}")]
        public void DeleteVendas(int codVendas)
        {
            repositorio.Remove(codVendas);

        }
    }
}