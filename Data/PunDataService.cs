using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class PunDataService
    {
        private readonly List<Pun> _puns;

        public PunDataService()
        {
            _puns = new List<Pun>
            {
                new Pun {PunId = 1, Title = "Lazy Bike", Joke = "Why can't a bike stand up on its own? It's two tired"},
                new Pun {PunId = 2, Title = "Pun 2", Joke = "Joke 2"},
                new Pun {PunId = 3, Title = "Pun 3", Joke = "Joke 3"}
            };
        }

        public Pun[] GetPuns()
        {
            return _puns.ToArray();
        }

        public Pun GetPunById(int punId)
        {
            return _puns.SingleOrDefault(p => p.PunId == punId);
        }
    }
}
