using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPiGamachicas.com.Entities
{
    public class Request<Tparameters>
    {

         public string Entorno { get; set; }
        public string Token { get; set; }
        public Tparameters parameter { get; set; }
    }
}
