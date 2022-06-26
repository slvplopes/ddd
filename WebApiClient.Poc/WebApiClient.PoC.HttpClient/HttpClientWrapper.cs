using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace WebApiClient.PoC.HttpClientServices
{
    public class HttpClientWrapper<TEntity> : IHttpClientWrapper<TEntity>
    {
        public async Task<TEntity> GetAsync(Uri baseUrl, string path)
        {
            TEntity entity = default(TEntity);

            using (var client = new System.Net.Http.HttpClient { BaseAddress = baseUrl })
            {
                AddRequesHeaders(client);

                HttpResponseMessage response = await client.GetAsync(path);

                if (response.IsSuccessStatusCode)
                {
                    entity = await response.Content.ReadAsAsync<TEntity>();
                }
            }

            return entity;
        }

        private static void AddRequesHeaders(System.Net.Http.HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}


