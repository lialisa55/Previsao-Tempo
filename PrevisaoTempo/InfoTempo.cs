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
            string main { get; set; }
            string descricao { get; set; }
            string icone { get; set; }
        }

        public class main
        {
            double temperatura { get; set; }
            double sensaTermica { get; set; }
            double tempMin { get; set; }
            double tempMax { get; set; }
            double humidade { get; set; }

        }
        
        public class root
        {
            public coordenada coordenada { get; set; }
            public List <tempo> tempo { get; set; }
            public main main { get; set; }
        }
    }
}
