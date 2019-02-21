using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPiGamachicas.com.BussinesLogical.Interface;
using WebAPiGamachicas.com.DataAcces;
using WebAPiGamachicas.com.Entities;
using WebAPiGamachicas.com.Entities.EntitiesBase;

namespace WebAPiGamachicas.com.BussinesLogical.Repository
{
    public class ImagenRepository : Iimagen
    {
        public Task<Response> listAllImagen(Request<Imagen> value)
        {
            var response = new Response();
            try
            {

                var Imagen = (Imagen)value.parameter;
                return Task.FromResult(response);
            }
            catch (Exception ex)
            {
                response.message = "Error interno";
                response.idStatus = 500;
                //throw ex;
            }
            return Task.FromResult(response);
        }


        //public Task<Response> listAllImagen(Request<Imagen> defaulvalue)
        //{

        //    var response = new Response() { idStatus = 1, message = "OK", parameter = null };
        //    try
        //    {

        //        var Imagen = Newtonsoft.Json.JsonConvert.DeserializeObject<Imagen>(defaulvalue.parameter);

        //        return Task.FromResult(response);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    return Task.FromResult(response);

        //}

    }
}
