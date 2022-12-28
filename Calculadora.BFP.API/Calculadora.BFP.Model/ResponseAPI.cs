using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.BFP.Model
{
    public class ResponseAPI
    {
        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public dynamic Respuesta { get; set; }
    }
}
