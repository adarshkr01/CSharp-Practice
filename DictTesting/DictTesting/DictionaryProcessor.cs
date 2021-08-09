using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DictTesting
{
    public class DictionaryProcessor
    {
        public static async Task<List<Root>> LoadData(string word)
        {
            string url = "https://api.dictionaryapi.dev/api/v2/entries/en_US/" + word;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    string str = await response.Content.ReadAsStringAsync();

                    //Console.WriteLine(str);
                    List<Root> myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(str);

                    return myDeserializedClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
