using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CovidAPI_Manipulation
{
    class Program
    {
        
        private const string GLOBAL_DATA_URL = "https://coronavirusapi-france.now.sh/FranceLiveGlobalData";
        private const string DATA_BY_DEPARTMENT_URL = "https://coronavirusapi-france.now.sh/LiveDataByDepartement";
        private const string ALL_DEPARTMENTS_URL = "https://coronavirusapi-france.now.sh/AllLiveData";

        private static HttpClient client;


        static async Task<string> GetGlobalDataAsync()
        {
            var data = string.Empty;
            var response = await client.GetAsync(GLOBAL_DATA_URL);

            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsStringAsync();
            }

            return data;
        }
        
        
        static void Main(string[] args)
        {

            client = new HttpClient();
            Console.WriteLine("COVID-19 France API Manipulation");

            while (true)
            {
                args = Console.ReadLine()?.Split(' ');
                var command = args?[0];

                switch (command)
                {
                    case "global":
                        var result =  GetGlobalDataAsync().GetAwaiter().GetResult();
                        Console.WriteLine(result);
                        break;
                    case "exit" :
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}