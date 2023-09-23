using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Models;

namespace WindowsForm.DAL
{
    public class ConsultaDolar
    {
        public ListDolar RealizaConsulta(string strURL)
        {
            var listDolar = new ListDolar();

            HttpClient client = new HttpClient();

            // client.DefaultRequestHeaders.Add("Authorization", "Token " + apiKey);

            var response = client.GetAsync(strURL).Result;
            
            if (response.IsSuccessStatusCode == true)
            {
                var result = response.Content.ReadAsStringAsync().Result;

                ListDolar consultaDolar = JsonConvert.DeserializeObject<ListDolar>(result);

                listDolar = consultaDolar;
            }

            return listDolar;
        }
    }
}