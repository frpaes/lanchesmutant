using Dao.DbModel;
using Dao.Interfaces;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class Lanches: Domain.Interfaces.ILanches
    {
        private Dao.Servicos.Lanches lanches;
        public Lanches()
        {
            lanches = new Dao.Servicos.Lanches();
        }

        public IEnumerable<CarregarVendasLanches> GetAllVendasLanches()
        {
            var vendasLanches = lanches.GetAllVendasLanches().ToList();
            var carregarVendasLanches = new List<CarregarVendasLanches>();
            foreach(var item in vendasLanches)
            {
                carregarVendasLanches.Add(new CarregarVendasLanches()
                {
                    Codigo = item.CODIGO,
                    CodLanche = item.COD_LANCHE,
                    Ingrediente = item.INGREDIENTE,
                    Lanche = item.LANCHE,
                    TipoLanche = item.TIPO_LANCHE,
                    Valor = item.VALOR
                });

            }



            return (IEnumerable<CarregarVendasLanches>)carregarVendasLanches;
        }

        public CarregarVendasLanches GetVendaLanche(int id)
        {
            var vendasLanche = lanches.GetVendaLanche(id);

            var carregarVendasLanches = vendasLanche == null ? new CarregarVendasLanches() : new CarregarVendasLanches()
            {
                Codigo = vendasLanche.CODIGO,
                CodLanche = vendasLanche.COD_LANCHE,
                Ingrediente = vendasLanche.INGREDIENTE,
                Lanche = vendasLanche.LANCHE,
                TipoLanche = vendasLanche.TIPO_LANCHE,
                Valor = vendasLanche.VALOR
            };

            return carregarVendasLanches;
        }
        public void Add(string codLanche, string descVenda)
        {
            lanches.Add(codLanche, descVenda);
        }
        public void Remove(int codigo)
        {
            lanches.Remove(codigo);
        }

        public IEnumerable<Model.Lanches> GetAllLanches()
        {
            var lanchesObj = lanches.GetAllLanches().ToList();
            var lanchesList = new List<Model.Lanches>();
            foreach (var item in lanchesObj)
            {
                lanchesList.Add(new Model.Lanches()
                {
                    Lanche = item.LANCHE,
                    CodLanche = item.COD_LANCHE

                });

            }

            return lanchesList;
        }

        public IEnumerable<Ingredientes> GetAllIngrediente()
        {
            var ingredientes = lanches.GetAllIngrediente().ToList();
            var ingredientesList = new List<Ingredientes>();
            foreach (var item in ingredientes)
            {
                ingredientesList.Add(new Ingredientes()
                {
                    CodIngrediente = item.COD_INGREDIENTE,
                    Ingrediente = item.INGREDIENTE,
                    Valor = item.VALOR

                });

            }

            return ingredientesList;
        }

        public IEnumerable<VendasLanches> GetAllVendasLanche()
        {
            var vendasLanches = lanches.GetAllVendasLanche().ToList();
            var vendasLanchesList = new List<VendasLanches>();
            foreach (var item in vendasLanches)
            {
                vendasLanchesList.Add(new VendasLanches()
                {
                    CodVendasLanche = item.COD_VENDAS_LANCHE,
                    CodVendas = item.COD_VENDAS,
                    CodDominio = item.COD_DOMINO.Value,
                    CodLanche = item.COD_LANCHE.Value
                    
                });

            }

            return vendasLanchesList;
        }

        public IEnumerable<Vendas> GetAllVendas()
        {
            var vendas = lanches.GetAllVendas().ToList();
            var vendasList = new List<Vendas>();
            foreach (var item in vendas)
            {
                vendasList.Add(new Vendas()
                {
                    CodVendas = item.COD_VENDAS,
                    DescVendas = item.DESC_VENDAS
                });

            }

            return vendasList;
        }

        public IEnumerable<Dominios> GetAllDominio()
        {
            var dominios = lanches.GetAllDominio().ToList();
            var retDominios = new List<Dominios>();
            foreach (var item in dominios)
            {
                retDominios.Add(new Dominios()
                {
                    CodDominio = item.COD_DOMINO,
                    CodTipoDominio = item.COD_TIPO_DOMINO,
                    Dominio = item.DOMINIO,
                    DescDominio = item.DESC_DOMINIO
                });

            }

            return retDominios;
        }

        public IEnumerable<LanchesIngredientes> GetAllLancheIngrediente()
        {
            var lancheIngrediente = lanches.GetAllLanchesIngrediente().ToList();
            var retlancheIngrediente = new List<LanchesIngredientes>();
            foreach (var item in lancheIngrediente)
            {
                retlancheIngrediente.Add(new LanchesIngredientes()
                {
                    CodIngrediente = item.COD_INGREDIENTE,
                    CodLanche = item.COD_LANCHE,
                    CodLancheIngrediente = item.COD_LANCHE_INGREDIENTE
                });

            }

            return retlancheIngrediente;
        }


    }
}
