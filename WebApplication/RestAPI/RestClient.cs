﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Collections;
using WebApplication.Models;

namespace WebApplication.RestAPI
{
    public class RestClient
    {
        HttpWebRequest req;

        private void CreateRequest(string url)
        {
            req = (HttpWebRequest)WebRequest.Create(url);

            req.ServicePoint.Expect100Continue = false;
            req.KeepAlive = false;
            req.Headers[HttpRequestHeader.Authorization] = "Basic YWxleHJjOmFwdGl2YTEy";
            req.Method = "Get";
            req.UserAgent = "WebApplication";
        }

        public string getAllUsers()
        {
            CreateRequest("https://api.github.com/users");

            try
            {
                using (StreamReader responseReader = new StreamReader(req.GetResponse().GetResponseStream()))
                    return responseReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            return JsonConvert.DeserializeObject<IEnumerable<User>>(getAllUsers());
        }
    }
}