using ExampleApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ExampleModel>> GetAll()
        {
            List<ExampleModel> values = new();
            for (int i = 1; i <= 10; i++ )
            {
                var example = new ExampleModel
                {
                    Id = i,
                    Name = $"Test {i}",
                    Description = $"Description {i} test",
                    Author = $"Author {i} Test",
                    AuthorId = i
                };
                values.Add(example);
            }
            return Ok(values);
        }
    }
}
