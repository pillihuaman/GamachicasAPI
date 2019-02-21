using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPiGamachicas.com.Entities.EntitiesBase
{
    public  class Imagen 
    {

        
        public int idimagen { set; get; }
       public string  name { set; get; }
        public double  size { set; get; }
        public string  path { set; get; }
        public int  posicion { set; get; }
        public string  posiciononPage { set; get; }
        public int  countList { set; get; }


    }
}
