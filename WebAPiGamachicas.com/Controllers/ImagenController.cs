using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebAPiGamachicas.com.BussinesLogical.Interface;
using WebAPiGamachicas.com.Config;
using WebAPiGamachicas.com.Entities;
using WebAPiGamachicas.com.Entities.EntitiesBase;

namespace WebAPiGamachicas.com.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class ImagenController : ControllerBase
    {
        private readonly Iimagen _Iimagen;
        private readonly IOptions<Configurationsetting> _config;
        public ImagenController(Iimagen imagen, IOptions<Configurationsetting> config)
        {
            _Iimagen = imagen;
            this._config = config;
        }
 
        [HttpPost]
        public async Task<Response<Imagen>> ListImagenTop([FromBody]  Request<Imagen> top)
        {
            top.Entorno = _config.Value.DefaultConnection;
            var lstimagen = await _Iimagen.listAllImagen(top);
            return lstimagen;
        }
     

        [HttpGet]

        public IActionResult get(string nombre)

        {
            var iimg= _Iimagen.ImageToByteArrayFromFilePath("C:\\Users\\pilli\\documents\\visual studio 2017\\Projects\\WebAPiGamachicas.com\\WebAPiGamachicas.com\\resources\\google.jpeg");
            return File(iimg, "image/jpeg");
        }
    

    }




}