using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPiGamachicas.com.Config;
using WebAPiGamachicas.com.Entities;
using WebAPiGamachicas.com.Entities.EntitiesBase;

namespace WebAPiGamachicas.com.BussinesLogical.Interface
{
    public interface Iimagen
    {
        Task<Response<Imagen>> listAllImagen(Request<Imagen> value );
        byte[] ImageToByteArrayFromFilePath(string imagefilePath);
    }
}
