using Microsoft.Extensions.Options;
using rfp_questions_service.Configuration;
using rfp_questions_service.Model;
using System.Text.Json;

namespace rfp_questions_service.apiclient
{
    public class OpenSearchApiClient : IOpenSearchApiClient
    {
        private readonly IOptions<OpenSearchConfig> _openSearchConfig;
        private readonly HttpClient _httpClient; 

        public OpenSearchApiClient(IOptions<OpenSearchConfig> openSearchConfig, IHttpClientFactory clientFactory)
        {
            _openSearchConfig = openSearchConfig;
            _httpClient = clientFactory.CreateClient("OpenSearchClient");
        }

        public async Task<List<RfpDetail>> Search(string searchVal)
        {
            List<RfpDetail> listRfpDetails = new List<RfpDetail>();

            using (var response = await _httpClient.GetAsync($"{_openSearchConfig.Value.Url}/{_openSearchConfig.Value.Index}/_search?q=content:({searchVal})"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                if (apiResponse != null)
                {
                    try
                    {
                        Rootobject? rootObject = JsonSerializer.Deserialize<Rootobject>(apiResponse);

                        if (rootObject != null && rootObject.hits != null)
                        {
                            foreach (var hit in rootObject.hits.hits)
                            {
                                listRfpDetails.Add(new RfpDetail()
                                {
                                    Url = hit._id,
                                    Name = hit._id.Substring(hit._id.LastIndexOf('/') + 1),
                                    Content = hit._source.content
                                });
                            }
                        }
                    }
                    catch (JsonException)
                    {
                        return listRfpDetails;
                    }
                }
            }

            return listRfpDetails;
        }
    }
}
