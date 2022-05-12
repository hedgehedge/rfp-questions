using rfp_questions_service.Model;

namespace rfp_questions_service.apiclient
{
    public interface IOpenSearchApiClient
    {
        Task<List<RfpDetail>> Search(string searchVal);
    }
}