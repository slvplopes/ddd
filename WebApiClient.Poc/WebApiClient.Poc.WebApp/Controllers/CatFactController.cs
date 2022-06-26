using Microsoft.AspNetCore.Mvc;
using WebApiClient.Poc.Core.Interfaces;
using WebApiClient.Poc.Core.Entities;
using WebApiClient.PoC.HttpClientServices.CatFacts;
using WebApiClient.PoC.HttpClientServices;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiClient.Poc.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatFactController : ControllerBase
    {
        // GET: api/<WeatherInfoController>
        [HttpGet]
        [Produces(typeof(CatFact))]
        public async Task<IActionResult> Get()
        {
            //return new[] { "x000", "xxx" };
            ICatFactService _catService = new CatFactService(new HttpClientWrapper<CatFact>());

            var result = await _catService.GetCatFactAsync().ConfigureAwait(false);

            return Ok(result);
        }
    }
}
