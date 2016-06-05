using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Serializable]
    public class Pun
    {
        public int PunId { get; set; }
        public string Title { get; set; }
        public string Joke { get; set; }
    }

    
}
