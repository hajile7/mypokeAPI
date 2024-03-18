using Newtonsoft.Json;
using System.Net;

namespace PokeAPI.Models.DALs
{
    public class AbilityInfoDAL
    {
        public static AbilityInfoModel GetAbilityInfo(string ability)
        {
            string url = $"https://pokeapi.co/api/v2/ability/{ability}/";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            AbilityInfoModel result = JsonConvert.DeserializeObject<AbilityInfoModel>(JSON);
            return result;
        }
    }
}
