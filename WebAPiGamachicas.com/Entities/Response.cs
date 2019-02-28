using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPiGamachicas.com.Entities
{
    public class Response<Tparameters>
    {
      public  int idStatus { get; set; }
       public  string message { get; set; }
        public Queue<Tparameters> parameter { get; set; }
    }
}
