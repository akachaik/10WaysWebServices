using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PunClient.DataServices;

namespace PunClient
{

    class Program
    {
        private static PunDataService _service;
        
        static void Main(string[] args)
        {
            _service = new PunDataService();
            var input = "";
            while (input.ToUpper() != "Q")
            {
                Console.WriteLine("------------------");
                Console.WriteLine("L) List puns");
                Console.WriteLine("#) Show specific pun");
                Console.WriteLine("N) Enter a new pun");
                Console.WriteLine("Q) Quit");

                var readLine = Console.ReadLine();
                if (readLine != null) input = readLine.ToUpper();

                var index = 0;
                if (input == "L")
                {
                    ListPuns();
                }
                else if (input == "N")
                {
                    EnterPun();
                }
                else if (Int32.TryParse(input, out index))
                {
                    ListPun(index);
                }
                else if (input == "#")
                {
                    
                }
            }
        }

        private static void ListPun(int index)
        {
            var pun = _service.GetPunById(index);
            Console.WriteLine("{0}) {1}", pun.PunId, pun.Joke);

        }

        private static void EnterPun()
        {
            throw new NotImplementedException();
        }

        private static void ListPuns()
        {
            foreach (var pun in _service.GetPuns())
            {
                Console.WriteLine("Pun Id : {0}", pun.PunId);
            }
        }
    }
}
