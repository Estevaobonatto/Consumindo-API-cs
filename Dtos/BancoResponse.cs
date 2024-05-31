using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INtegraBrasilAPI.Dtos
{
    public class BancoResponse
    {
        public String? Ispb { get; set; }
        public String? NomeAbreviado { get; set; }
        public int Codigo { get; set; }
        public String? NomeCompleto { get; set; }
        
    }
}