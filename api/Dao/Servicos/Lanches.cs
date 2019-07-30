using Dao.DbModel;
using Dao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Servicos
{
    public class Lanches: ILanches
    {
        private Dao.DbModel.Entities _entities;
        public Lanches()
        {
            _entities = new Dao.DbModel.Entities();
        }

        public IEnumerable<USP_CARREGAR_VENDAS_LANCHE_Result> GetAllVendasLanches()
        {
            var retorno = (IEnumerable<USP_CARREGAR_VENDAS_LANCHE_Result>)_entities.USP_CARREGAR_VENDAS_LANCHE();
            return retorno;
        }

        public USP_CARREGAR_VENDAS_LANCHE_Result GetVendaLanche(int id)
        {
            var retorno = _entities.USP_CARREGAR_VENDAS_LANCHE().FirstOrDefault(x => x.CODIGO == id);
            return retorno;
        }
        public void Add(string codLanche, string descVenda)
        {
            _entities.USP_INSERIR_VENDAS_LANCHE(codLanche, descVenda);
        }
        public void Remove(int codigo)
        {
            _entities.USP_DELETA_VENDAS_LANCHES(codigo);
        }

        public IEnumerable<USP_TB_LANCHE_Result> GetAllLanches()
        {
            var retorno = (IEnumerable<USP_TB_LANCHE_Result>)_entities.USP_TB_LANCHE();
            return retorno;
        }

        public IEnumerable<USP_TB_INGREDIENTE_Result> GetAllIngrediente()
        {
            var retorno = (IEnumerable<USP_TB_INGREDIENTE_Result>)_entities.USP_TB_INGREDIENTE();
            return retorno;
        }

        public IEnumerable<USP_TB_VENDAS_LANCHES_Result> GetAllVendasLanche()
        {
            var retorno = (IEnumerable<USP_TB_VENDAS_LANCHES_Result>)_entities.USP_TB_VENDAS_LANCHES();
            return retorno;
        }

        public IEnumerable<USP_TB_VENDAS_Result> GetAllVendas()
        {
            var retorno = (IEnumerable<USP_TB_VENDAS_Result>)_entities.USP_TB_VENDAS();
            return retorno;
        }

        public IEnumerable<USP_TB_DOMINIO_Result> GetAllDominio()
        {
            var retorno = (IEnumerable<USP_TB_DOMINIO_Result>)_entities.USP_TB_DOMINIO();
            return retorno;
        }

        public IEnumerable<USP_TB_LANCHE_INGREDIENTE_Result> GetAllLanchesIngrediente()
        {
            var retorno = (IEnumerable<USP_TB_LANCHE_INGREDIENTE_Result>)_entities.USP_TB_LANCHE_INGREDIENTE();
            return retorno;
        }

    }
}
