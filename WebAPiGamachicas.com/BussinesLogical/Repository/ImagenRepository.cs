using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebAPiGamachicas.com.BussinesLogical.Interface;
using WebAPiGamachicas.com.Config;
using WebAPiGamachicas.com.DataAcces;
using WebAPiGamachicas.com.Entities;
using WebAPiGamachicas.com.Entities.EntitiesBase;

namespace WebAPiGamachicas.com.BussinesLogical.Repository
{
    public class ImagenRepository : Iimagen
    {
        //public byte[] ImageToByteArrayFromFilePath(string imagefilePath)
        //{
        //    byte[] imageArray = File.ReadAllBytes(imagefilePath);
        //    return imageArray;
        //}
        //public int Id { get; set; }
        //public string Title { get; set; }
        //public string Content { get; set; }

        //[JsonIgnore]
        //public AppDb Db { get; set; }

        //public ImagenRepository(AppDb db = null)
        //{
        //    Db = db;
        //}


        //public async Task<Response> listAllImagen()
        //{
        //    try
        //    {


        //        //Helper help = new Helper();
        //        int Id = 0;
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

        ////}
        //public async Task DeleteAsync()
        //{
        //    var cmd = Db.Connection.CreateCommand() as MySqlCommand;
        //    cmd.CommandText = @"DELETE FROM `BlogPost` WHERE `Id` = @id;";
        //    BindId(cmd);
        //    await cmd.ExecuteNonQueryAsync();
        //}

        //private void BindId(MySqlCommand cmd)
        //{
        //    cmd.Parameters.Add(new MySqlParameter
        //    {
        //        ParameterName = "@id",
        //        DbType = DbType.Int32,
        //        Value = Id,
        //    });
        //}

        //private void BindParams(MySqlCommand cmd)
        //{
        //    cmd.Parameters.Add(new MySqlParameter
        //    {
        //        ParameterName = "@title",
        //        DbType = DbType.String,
        //        Value = Title,
        //    });
        //    cmd.Parameters.Add(new MySqlParameter
        //    {
        //        ParameterName = "@content",
        //        DbType = DbType.String,
        //        Value = Content,
        //    });
        //}


        //public async Task<Response> listAllImagen(Request<Imagen> value)
        //{
        //    var response = new Response();
        //    try
        //    {

        //        var mar = new ImagenDA();
        //        mar.getdata();
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        response.message = "Error interno";
        //        response.idStatus = 500;
        //        //throw ex;
        //    }
        //    return null;
        //    //return Task.FromResult(response);
        //}

        public byte[] ImageToByteArrayFromFilePath(string imagefilePath)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Imagen>> listAllImagen(Request<Imagen> value)
        {
            ImagenDA.getdata(value);
            return null;
        }
    }
}
