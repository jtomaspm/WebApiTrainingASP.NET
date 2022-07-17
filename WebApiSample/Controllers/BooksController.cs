using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private String[]? content = Array.Empty<String>();

        [HttpGet]
        public IEnumerable<String> Get()
        {
            if (content.Length > 0) {
                return content;
            }
            return new[] { "test", "book" };
        }

        [HttpPost]
        public void Post()
        {
            content = new[] { "test", "changed" };
        }

    }
}
