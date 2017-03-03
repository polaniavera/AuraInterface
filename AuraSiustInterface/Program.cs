using AuraInterface.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AuraSiustInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            string responseString = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://190.146.192.36:45455");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("/api/norma/get/3").Result;
                if (response.IsSuccessStatusCode)
                {
                    responseString = response.Content.ReadAsStringAsync().Result;
                }
            }

            Norma norma = JsonConvert.DeserializeObject<Norma>(responseString);
            Console.WriteLine("Fecha prueba:" + DateTime.Now+"\nNorma.nombre: "+norma.NombreNorma + "\nNorma.Descripcion: "+norma.Descripcion +"\nNorma.Id: "+norma.IdNorma +"\nNorma.Codigo: "+norma.CodigoNorma);
            Console.ReadLine();
        }
    }
}
