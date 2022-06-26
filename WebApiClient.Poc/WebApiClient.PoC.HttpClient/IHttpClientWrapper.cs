using System;
using System.Threading.Tasks;

namespace WebApiClient.PoC.HttpClientServices
{
    public interface IHttpClientWrapper<TEntity>
    {
        Task<TEntity> GetAsync(Uri baseUrl, string path);
    }
}