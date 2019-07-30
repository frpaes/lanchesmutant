using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LanchoneteMutant.Controllers
{
    
    public class LanchesController : ApiController
    {
        static readonly Domain.Servicos.Lanches repositorio = new Domain.Servicos.Lanches();

        [HttpGet]
        [Route("api/GetAllLanches")]
        public IEnumerable<Lanches> GetAllLanches()
        {
            var lanches = repositorio.GetAllLanches();
            var lancheIngredienteList = repositorio.GetAllLancheIngrediente().ToList();
            var ingredienteList = repositorio.GetAllIngrediente().ToList();
            //var retIngrediente = new List<Ingredientes>();

            foreach (var item in lanches)
            {
                var lancheIngrediente = lancheIngredienteList.Where(x => x.CodLanche == item.CodLanche).ToList();

                item.Ingredientes = new List<Ingredientes>();
                foreach (var item2 in lancheIngrediente)
                {
                    var ingr = ingredienteList.Where(x => x.CodIngrediente == item2.CodIngrediente).FirstOrDefault();
                    item.Ingredientes.Add(new Ingredientes
                    {
                        CodIngrediente = ingr.CodIngrediente,
                        Ingrediente = ingr.Ingrediente,
                        Valor = ingr.Valor
                    });
                }
            }


            return lanches;
        }


        [HttpGet]
        [Route("api/GetAllLanchesIngrediente/{codLanche}")]
        public IEnumerable<Ingredientes> GetAllLanchesIngrediente(int codLanche)
        {
            var lancheIngrediente = repositorio.GetAllLancheIngrediente().ToList().Where(x => x.CodLanche == codLanche).ToList();
            var ingredienteList = repositorio.GetAllIngrediente().ToList();
            var retIngrediente = new List<Ingredientes>();

            foreach (var item in lancheIngrediente)
            {
                var ingr = ingredienteList.Where(x => x.CodIngrediente == item.CodIngrediente).FirstOrDefault();
                retIngrediente.Add(new Ingredientes
                {
                    CodIngrediente = ingr.CodIngrediente,
                    Ingrediente = ingr.Ingrediente,
                    Valor = ingr.Valor
                });
            }
            return (IEnumerable<Ingredientes>) retIngrediente;
        }

    }
}