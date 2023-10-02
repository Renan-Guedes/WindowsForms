using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Models;

namespace WindowsForm.DAL
{
    public class ConsultaUsers
    {
        public async Task<ListDataUsersItems> RealizaConsulta(string strURL)
        {
            var listusers = new ListDataUsersItems();

            using(HttpClient client = new HttpClient()) 
            {
                var response = await client.GetAsync(strURL);

                if (response.IsSuccessStatusCode == true)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    
                    listusers = JsonConvert.DeserializeObject<ListDataUsersItems>(result);
                }
            }

            return listusers;
        }
    }
}
