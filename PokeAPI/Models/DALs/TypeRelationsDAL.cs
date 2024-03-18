using Newtonsoft.Json;
using System.Net;

namespace PokeAPI.Models.DALs
{
    public class TypeRelationsDAL
    {
        public static TypeRelationsModel GetTypeInfo(string type)
        {
            string url = $"https://pokeapi.co/api/v2/type/{type}/";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            TypeRelationsModel result = JsonConvert.DeserializeObject<TypeRelationsModel>(JSON);
            return result;
        }
    }
}
