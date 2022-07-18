using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinomialController : ControllerBase
    {

        public class BinomialForm
        {
            public int SampleTotal { get; set; }
            public float Chance { get; set; }
        }


        [HttpPost]
        public async Task<ActionResult<Binomial>> PutBinomial(BinomialForm BF)
        {
            Binomial res = new Binomial
            {
                Size = BF.SampleTotal,
                Chance = BF.Chance
            };
            return res;
        }
    }
}
