using DaddyJokesWebApp.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DaddyJokesWebApp.Services
{
    /// <summary>
    /// DaddyJokeservice is to call external api and provide data.
    /// </summary>
    public class DaddyJokeservice : IDaddyJokeservice
    {
        private readonly IHttpClientFactory _httpClientFactory = null!;
        private Uri _uri = null;
        public DaddyJokeservice(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }
        public async Task<Joke> GetRandomJoke()
        {
           _uri = new Uri("https://dad-jokes.p.rapidapi.com/random/joke");
           return await GetJoke<Joke>();
        }
        /// <summary>
        /// Generic method to return T here T could be Joke or JokeCount
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private async Task<T> GetJoke<T>()
        {
            T item;
            using HttpClient client = this._httpClientFactory.CreateClient();
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = this._uri,
                    Headers =
                    {
                        { "X-RapidAPI-Key", "5c455f70e8mshf8dae063899c96ap12c323jsnf3b5c3d9dacd" },
                        { "X-RapidAPI-Host", "dad-jokes.p.rapidapi.com" },
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var result = await response.Content.ReadAsStringAsync();
                    item = JsonConvert.DeserializeObject<T>(result);
                }

                return item;
            }
        }
        public async Task<JokeCount> GetRandomJokeCount()
        {
            _uri = new Uri("https://dad-jokes.p.rapidapi.com/joke/count");
            return await GetJoke<JokeCount>();
        }
    }
}
