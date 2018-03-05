using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class ArbolCadena
    {
        public String valor { get; set; }
        public ArbolCadena izquierdo { get; set; }
        public ArbolCadena derecho { get; set; }
    }
}