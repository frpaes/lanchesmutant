using Domain.Interfaces;
using Domain.Model;
using Domain.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace LanchoneteMutant.Controllers
{
    public class CarregarVendasLanchesController : ApiController
    {

        static readonly Domain.Servicos.Lanches repositorio = new Domain.Servicos.Lanches();

        [HttpGet]
        [Route("api/GetAllVendasLanches")]
        public IEnumerable<CarregarVendasLanches> GetAllVendasLanches()
        {
            return repositorio.GetAllVendasLanches();
        }

        [HttpGet]
        [Route("api/GetVendaLanche/{id}")]
        public CarregarVendasLanches GetVendaLanche(int id)
        {
            CarregarVendasLanches item = repositorio.GetVendaLanche(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        //public HttpResponseMessage PostProduto(Produto item)
        //{
        //    item = repositorio.Add(item);
        //    var response = Request.CreateResponse<Produto>(HttpStatusCode.Created, item);

        //    string uri = Url.Link("DefaultApi", new { id = item.Id });
        //    response.Headers.Location = new Uri(uri);
        //    return response;
        //}

        //public void PutProduto(int id, Produto produto)
        //{
        //    produto.Id = id;
        //    if (!repositorio.Update(produto))
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //}

        //public void DeleteProduto(int id)
        //{
        //    Produto item = repositorio.Get(id);

        //    if (item == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }

        //    repositorio.Remove(id);
        //}

    }
}