using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Lanches
    {
        public int CodLanche { get; set; }
        public string Lanche { get; set; }

        public List<Ingredientes> Ingredientes { get; set; }
    }
}
