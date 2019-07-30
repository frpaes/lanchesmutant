using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class CarregarVendasLanches
    {
        public int Codigo { get; set; }
        public int CodLanche { get; set; }
        public string Lanche { get; set; }
        public string TipoLanche { get; set; }
        public string Ingrediente { get; set; }
        public Nullable<decimal> Valor { get; set; }
    }
}
