using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi2.Models
{
    public class Platos
    {
        public int platoId { get; set; }
        public string platoNombre { get; set; }
      
        public string platodescrip { get; set; }
        public Nullable<decimal> platoprice { get; set; }
       
        public string imageUrl { get; set; }
    }
}
