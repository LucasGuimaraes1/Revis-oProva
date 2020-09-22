using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.P.I_Futebol.Models
{
    public class Time
    {
        public int ID { get; set; }
        public string Nome{ get; set; }
        public int AnoCriação { get; set; }
        public string Estado { get; set; }
        public string Bandeira { get; set; }
        public string Mascote { get; set; }
        public int QtdeTitulosBR { get; set; }
        public int QtdeTituloCopaBr { get; set; }
        public int QtdeTituloRegional { get; set; }

    }
}
