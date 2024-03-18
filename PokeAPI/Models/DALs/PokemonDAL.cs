using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace PokeAPI.Models.DALs
{
    public class PokemonDAL
    {
        public static PokemonModel GetPokemon(string pokemon)
        {
            string url = $"https://pokeapi.co/api/v2/pokemon/{pokemon.ToLower().Trim()}/";

            try
            {
                HttpWebRequest request = WebRequest.CreateHttp(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string JSON = reader.ReadToEnd();

                    PokemonModel result = JsonConvert.DeserializeObject<PokemonModel>(JSON);
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (WebException ex)
            {
                return null; 
            }
        }
    }
}
