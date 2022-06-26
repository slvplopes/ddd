using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClient.Poc.Core.Entities;

namespace WebApiClient.Poc.Core.Interfaces
{
    public interface ICatFactService
    {
       Task<CatFact> GetCatFactAsync();
    }
}
