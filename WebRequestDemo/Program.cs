using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebRequestDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = HttpClientFactory.Create();

            var url = "https://jsonplaceholder.typicode.com/todos/1";
            //var data = await httpClient.GetStringAsync(url);
            
           HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                var data = await content.ReadAsStringAsync();
                Console.WriteLine(data);

            }
         

            Console.WriteLine("Hello World!");

        }
    }
}
