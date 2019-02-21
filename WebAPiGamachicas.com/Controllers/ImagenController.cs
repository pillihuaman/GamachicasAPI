using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPiGamachicas.com.BussinesLogical.Interface;
using WebAPiGamachicas.com.Entities;
using WebAPiGamachicas.com.Entities.EntitiesBase;

namespace WebAPiGamachicas.com.Controllers
{

     

    [Route("api/[controller]")]
    [ApiController]
    public class ImagenController : ControllerBase
    {
        private readonly Iimagen _Iimagen;
        public ImagenController(Iimagen imagen)
        {
            _Iimagen = imagen;
        }
        [HttpPost]
        public async Task<Response> ListImagenTop([FromBody]  Request<Imagen> top)
        {
            var lstimagen = await _Iimagen.listAllImagen(top);
            return lstimagen;
        }

    }
}