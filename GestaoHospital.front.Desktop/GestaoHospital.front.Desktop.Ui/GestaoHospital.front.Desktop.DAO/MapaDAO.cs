using GestaoHospital.front.Desktop.DAO.Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GestaoHospital.front.Desktop.DAO
{
    public class MapaDAO
    {
        private readonly IConfiguration _configuration;
        public MapaDAO( IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public (bool sucesso, List<EntityMapa>) ObtemMapas(string nome = "", string id = "")
        {            
            string URLAPI = _configuration.GetSection("URL_API").Value;
            string PATHMAPA = _configuration.GetSection("PATH_MAPA").Value; 
            var client = new HttpClient();
            JObject filter = new JObject();
            filter["id"] = null;
            JObject jsonEndereco = new JObject();
            jsonEndereco["filter"] = filter;
            jsonEndereco["pageNumber"] = "1";
            jsonEndereco["pageSize"] = "40";
            string json = jsonEndereco.ToString(); //System.Text.Json.JsonSerializer.Serialize("{\"filter\":{},\"pageNumber\":1,\"pageSize\":40}");
            var url = $"{URLAPI}{PATHMAPA}ObterMapas";            
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            var content = new StringContent(json, null, "application/json");
            request.Content = content;
            var response = client.SendAsync(request).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            if (!string.IsNullOrEmpty(result))
            {
                List<EntityMapa> mapas = JsonConvert.DeserializeObject<List<EntityMapa>>(result);
                return (response.IsSuccessStatusCode,mapas);

            }else
            {
                return (false, null);
            }
        }
    }
}
