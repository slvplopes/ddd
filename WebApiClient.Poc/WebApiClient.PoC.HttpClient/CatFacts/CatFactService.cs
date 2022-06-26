using System;
using System.Threading.Tasks;
using WebApiClient.Poc.Core.Entities;
using WebApiClient.Poc.Core.Interfaces;

namespace WebApiClient.PoC.HttpClientServices.CatFacts
{
    public class CatFactService : ICatFactService
    {
        private readonly string endpoint = "https://catfact.ninja/fact";
        private readonly IHttpClientWrapper<CatFact> _httpClientWrapper;

        public CatFactService(IHttpClientWrapper<CatFact> httpClientWrapper)
        {
            _httpClientWrapper = httpClientWrapper;
        }

        public async Task<CatFact> GetCatFactAsync()
        {
            CatFact _catFact = await _httpClientWrapper.GetAsync(new Uri(endpoint), "");

            return _catFact;
        }
        
    }
}
