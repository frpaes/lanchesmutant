using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class VendasLanches
    {
        public int CodVendasLanche{ get; set; }
        public int CodVendas { get; set; }
        public Nullable<int> CodLanche { get; set; }
        public Nullable<int> CodDominio { get; set; }
    }
}
