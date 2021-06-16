using Newtonsoft.Json;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podatkovni_Sloj
{
    public class GetData
    {
        private string Source()
        {
            if (System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Source.txt")) == "men")
            {
                return "https://world-cup-json-2018.herokuapp.com";
            }
            else
            {
                return "https://worldcup.sfg.io";
            }
        }
        public Task<List<Utakmice>> GetUtakmice()
        {

            return Task.Run(() =>
            {
                var restClient = new RestClient($"{Source()}/matches");

                var result = restClient.Execute<Utakmice>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Utakmice>>(result.Content);

            });
        }
        public Task<List<Reprezentacije>> GetReprezentacije()
        {

            return Task.Run(() =>
            {
                var restClient = new RestClient($"{Source()}/teams");

                var result = restClient.Execute<Reprezentacije>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Reprezentacije>>(result.Content);

            });
        }
    }
}
