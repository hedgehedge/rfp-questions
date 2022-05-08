using Microsoft.AspNetCore.Mvc;
using rfp_questions_service.apiclient;

namespace rfp_questions_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RfpQuestionController : ControllerBase
    {
        [HttpGet(Name = "GetRfpDetail")]
        public async Task<IActionResult> GetRfpDetail([FromQuery] string searchVal)
        {
            OpenSearchApiClient openSearchApiClient = new OpenSearchApiClient();

            var result = await openSearchApiClient.Search(searchVal);
            
            return Ok(result);
        }

    }
}
