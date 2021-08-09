using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DictTesting
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ApiHelper.InitializeClient();
            await MakeCalls();
        }

        public static async Task MakeCalls()
        {
            var parsedData = await DictionaryProcessor.LoadData("fbi");

            foreach(Root data in parsedData)
            {
                foreach (Meaning meaning in data.meanings)
                {
                    Console.WriteLine(meaning.partOfSpeech);
                    foreach (Definition definition in meaning.definitions)
                    {
                        Console.WriteLine(definition.definition + "\n");
                    }
                }
                
            }
        }
    }
}
