using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Domain
{

    public class Questao
    {
        public int Numero { get; set; }
        public string Pergunta { get; set; }
        public string Resp1 { get; set; }
        public string Resp2 { get; set; }
        public string Resp3 { get; set; }
        public string Resp4 { get; set; }
        public int Certa { get; set; }
        public string Nivel { get; set; }
        public string JaFoi { get; set; }
        public string Materia { get; set; }
    }
}
