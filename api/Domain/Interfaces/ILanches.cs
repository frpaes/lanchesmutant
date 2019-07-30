using Dao.DbModel;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ILanches
    {
        IEnumerable<CarregarVendasLanches> GetAllVendasLanches();

        CarregarVendasLanches GetVendaLanche(int id);

        void Add(string codLanche, string descVenda);

        void Remove(int codigo);

        IEnumerable<Lanches> GetAllLanches();

        IEnumerable<Ingredientes> GetAllIngrediente();

        IEnumerable<VendasLanches> GetAllVendasLanche();

        IEnumerable<Vendas> GetAllVendas();

        IEnumerable<Dominios> GetAllDominio();

        IEnumerable<LanchesIngredientes> GetAllLancheIngrediente();
    }
}
