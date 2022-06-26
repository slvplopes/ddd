using System.Threading.Tasks;

using WebApiClient.Poc.Core.Interfaces;
using WebApiClient.Poc.Core.Entities;
using WebApiClient.PoC.HttpClientServices;
using WebApiClient.PoC.HttpClientServices.CatFacts;

namespace WebApiClient.Poc.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var result = Run();

            System.Console.WriteLine(result.Fact);

            
        }

        private static CatFact Run()
        {
            ICatFactService _catFactService = new CatFactService(new HttpClientWrapper<CatFact>());

            return _catFactService.GetCatFactAsync().GetAwaiter().GetResult();
        }
    }
}
