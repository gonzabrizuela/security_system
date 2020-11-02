using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Historial
    {

        public int Indice { get; set; }
        public string Temperatura { get; set; }
        public string Peso { get; set; }
        public DateTime Fecha { get; set; }         
        public bool Alarma { get; set; }
       
    }
}
