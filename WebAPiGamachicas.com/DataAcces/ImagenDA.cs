using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPiGamachicas.com.Entities;

namespace WebAPiGamachicas.com.DataAcces
{
    public class ImagenDA
    {
        public static Task<Response> listAllImagen()
        {         
            return Task.FromResult(new Response { idStatus = 1, message = "ok" });
        }
     
    }
}
