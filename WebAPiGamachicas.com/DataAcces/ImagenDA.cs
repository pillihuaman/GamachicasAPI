using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPiGamachicas.com.Config;
using WebAPiGamachicas.com.Entities;
using WebAPiGamachicas.com.Entities.EntitiesBase;
using WebAPiGamachicas.com.Utils;
using Dapper;

namespace WebAPiGamachicas.com.DataAcces
{
    public   class ImagenDA
    {


        public static Response<Imagen> getdata(Request<Imagen> value)
        {

            List<clothing> Imagen = new List<clothing>();
            Queue<Response> lst = new Queue<Entities.Response>();

            using (IDbConnection db=new MySqlConnection(value.Entorno))
            {
                var salida = db.Query<clothing>("sp_listTopImagen", new { top = 1 }, commandType: CommandType.StoredProcedure).ToArray();
                Imagen = db.Query<clothing>("SELECT idclothing,idclothingline,NAME,DESCRIPTION from gamachicas.clothing;").ToList();
            }
            //using (MySqlConnection conn = new MySqlConnection(value.Entorno))
            //{
            //    conn.Open();
            //    MySqlCommand cmd = new MySqlCommand("SELECT idclothing,idclothingline,NAME,DESCRIPTION from gamachicas.clothing; ;", conn);
            //    using (var reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            clothing clo = new clothing();
            //            clo.idclothing = (reader["idclothing"].ToString());
            //            clo.idclothingline = reader["idclothingline"].ToString();
            //            clo.NAME = reader["NAME"].ToString();
            //            clo.DESCRIPTION = (reader["DESCRIPTION"].ToString());
            //            Imagen.Add(clo);
            //        }
            //    }
            //}
            return null;
        }
        //public   async Task<Response> listAllImagen()
        //{
        //    try
        //    {
               

        ////Helper help = new Helper();
        //int Id = 0;
        //        var cmd = Db.Connection.CreateCommand() as MySqlCommand;

        //        cmd.CommandText = @"INSERT INTO `gamachicas`.`clothing` (`idclothing`,`idclothingline`,`NAME`,`DESCRIPTION`,`idcolor`,`positionweb`,`countview`,`STATUS`,`createdate`,`updatedate`)VALUES(default,34,'calson','calson',1,2,3,true,sysdate(),sysdate());";
        //        BindParams(cmd);
        //        await cmd.ExecuteNonQueryAsync();
        //        Id = (int)cmd.LastInsertedId;
        //        return null;

        //        //return Task.FromResult(new Response { idStatus = 1, message = "ok" });
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        
        //    }

    }
}
