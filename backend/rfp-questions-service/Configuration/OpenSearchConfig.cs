namespace rfp_questions_service.Configuration
{
    public class OpenSearchConfig
    {
        public static readonly string ConfigSection = "OpenSearch";
        public string Url { get; set; }
        public string Index { get; set; }
    }
}
