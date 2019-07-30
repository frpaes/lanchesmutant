using Dao.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Interfaces
{
    public interface ILanches
    {
        IEnumerable<USP_CARREGAR_VENDAS_LANCHE_Result> GetAllVendasLanches();

        USP_CARREGAR_VENDAS_LANCHE_Result GetVendaLanche(int id);

        void Add(string codLanche, string descVendas);

        void Remove(int codigo);

        IEnumerable<USP_TB_LANCHE_Result> GetAllLanches();

        IEnumerable<USP_TB_INGREDIENTE_Result> GetAllIngrediente();

        IEnumerable<USP_TB_VENDAS_Result> GetAllVendas();

        IEnumerable<USP_TB_VENDAS_LANCHES_Result> GetAllVendasLanche();

        IEnumerable<USP_TB_DOMINIO_Result> GetAllDominio();

        IEnumerable<USP_TB_LANCHE_INGREDIENTE_Result> GetAllLanchesIngrediente();
    }
}
