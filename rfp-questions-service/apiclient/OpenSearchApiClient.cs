using rfp_questions_service.Model;
using System.Text.Json;

namespace rfp_questions_service.apiclient
{
    public class OpenSearchApiClient
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<List<RfpDetail>> Search(string searchVal)
        {
            List<RfpDetail> listRfpDetails = new List<RfpDetail>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"http://localhost:9200/rfp_questions/_search?q=content:({searchVal})"))
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
            }

            return listRfpDetails;
        }
    }
}
