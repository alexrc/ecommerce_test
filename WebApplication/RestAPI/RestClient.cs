using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

namespace WebApplication.RestAPI
{
    public class RestClient
    {
        HttpClient client;
        Uri usuarioUri;

        public RestClient()
        {
            if (client == null)
            {
                //client = new HttpClient();
                //client.BaseAddress = new Uri("https://api.github.com/");
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", //"YWxleHJjOmFwdGl2YTEy");
                //Convert.ToBase64String(
                //        System.Text.ASCIIEncoding.ASCII.GetBytes(
                //            string.Format("{0}:{1}", "alexrc", "aptiva12"))));

            // New code:
            //HttpResponseMessage response = await client.GetAsync("api/products/1");
            //if (response.IsSuccessStatusCode)
            //{
            //    Product product = await response.Content.ReadAsAsync>Product>();
            //    Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
            //}
            }

        }

        public HttpResponseMessage getAll()
        {
            //HttpResponseMessage response;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://api.github.com/users");
            //chamando a api pela url
            //response = client.GetAsync("/users").Result;
            req.ServicePoint.Expect100Continue = false;
            req.KeepAlive = false;
            req.Headers[HttpRequestHeader.Authorization] = "Basic YWxleHJjOmFwdGl2YTEy";
            

            WebResponse resp = req.GetResponse();

            //se retornar com sucesso busca os dados
            //if (response.IsSuccessStatusCode)
            //{
            //    //pegando o cabeçalho
            //    usuarioUri = response.Headers.Location;

            //    //Pegando os dados do Rest e armazenando na variável usuários
            //    //var usuarios = response.Content.ReadAsAsync<IEnumerable<Usuario>>().Result;

            //    ////preenchendo a lista com os dados retornados da variável
            //    //GridView1.DataSource = usuarios;
            //    //GridView1.DataBind();
            //}

            //Se der erro na chamada, mostra o status do código de erro.
            //else
            //    //Response.Write(response.StatusCode.ToString() + " - " + response.ReasonPhrase);


            return null;
        }

    }
}