using Microsoft.AspNetCore.Mvc;
using rfp_questions_service.apiclient;

namespace rfp_questions_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RfpQuestionController : ControllerBase
    {
        private readonly IOpenSearchApiClient _openSearchApiClient;
        public RfpQuestionController(IOpenSearchApiClient openSearchApiClient)
        {
            _openSearchApiClient = openSearchApiClient;
        }

        [HttpGet(Name = "GetRfpDetail")]
        public async Task<IActionResult> GetRfpDetail([FromQuery] string searchVal)
        {
            var result = await _openSearchApiClient.Search(searchVal);
            
            return Ok(result);
        }

    }
}
