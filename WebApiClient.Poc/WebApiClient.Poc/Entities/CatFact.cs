using System;

namespace WebApiClient.Poc.Core.Entities
{
    public class CatFact: Entity
    {
        public CatFact() : base()
        {
           CatFactID = Guid.NewGuid().ToString();
        }
        public string CatFactID { get; set; }
        public string Fact { get; set; }
        public string Length { get; set; }
    }
}
