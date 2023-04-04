using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevisaoTempo
{
    class InfoTempo
    {
        public class coordenada
        {
            double latitude { get; set; }
            double longitude { get; set; }
        }

        public class tempo
        {
            public string main { get; set; }
            public string descricao { get; set; }
            public string icone { get; set; }
        }

        public class main
        {
            public double temperatura { get; set; }
            public double sensaTermica { get; set; }
            public double tempMin { get; set; }
            public double tempMax { get; set; }

        }
        
        public class root
        {
            public coordenada coordenada { get; set; }
            public List <tempo> tempo { get; set; }
            public main main { get; set; }
        }
    }
}
