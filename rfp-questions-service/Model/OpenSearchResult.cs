namespace rfp_questions_service.Model
{
    public class Rootobject
    {
        public int took { get; set; }
        public bool timed_out { get; set; }
        public _Shards _shards { get; set; }
        public Hits hits { get; set; }
    }

    public class _Shards
    {
        public int total { get; set; }
        public int successful { get; set; }
        public int skipped { get; set; }
        public int failed { get; set; }
    }

    public class Hits
    {
        public Total total { get; set; }
        public float max_score { get; set; }
        public Hit[] hits { get; set; }
    }

    public class Total
    {
        public int value { get; set; }
        public string relation { get; set; }
    }

    public class Hit
    {
        public string _index { get; set; }
        public string _type { get; set; }
        public string _id { get; set; }
        public float _score { get; set; }
        public _Source _source { get; set; }
    }

    public class _Source
    {
        public string collectorcontenttype { get; set; }
        public DateTime date { get; set; }
        public string[] collectorlocalFileaclALLOWWRITE_NAMED_ATTRS { get; set; }
        public string TableCount { get; set; }
        public string collectorfilesize { get; set; }
        public string DataBitsPerSample { get; set; }
        public string[] collectorlocalFileaclALLOWDELETE_CHILD { get; set; }
        public string DataPlanarConfiguration { get; set; }
        public string[] collectorlocalFileaclALLOWEXECUTE { get; set; }
        public string metaobjectcount { get; set; }
        public string ChromaColorSpaceType { get; set; }
        public string[] collectorlocalFileaclALLOWWRITE_ATTRIBUTES { get; set; }
        public string ContentEncoding { get; set; }
        public DateTime modified { get; set; }
        public string[] collectorlocalFileaclALLOWREAD_DATA { get; set; }
        public string tiffBitsPerSample { get; set; }
        public string[] collectorlocalFileaclALLOWREAD_ACL { get; set; }
        public string height { get; set; }
        public DateTime metacreationdate { get; set; }
        public string metatablecount { get; set; }
        public string DimensionPixelAspectRatio { get; set; }
        public DateTime CreationDate { get; set; }
        public string XTIKAorigResourceName { get; set; }
        public string editingcycles { get; set; }
        public string[] collectorlocalFileaclALLOWWRITE_DATA { get; set; }
        public string documentcontentType { get; set; }
        public string CompressionLossless { get; set; }
        public string DimensionImageOrientation { get; set; }
        public string[] collectorlocalFileaclALLOWWRITE_OWNER { get; set; }
        public string DataSampleFormat { get; set; }
        public string[] collectorlocalFileaclALLOWREAD_ATTRIBUTES { get; set; }
        public string documentcontentFamily { get; set; }
        public string TransparencyAlpha { get; set; }
        public string collectorlastmodified { get; set; }
        public string[] collectorlocalFileaclALLOWWRITE_ACL { get; set; }
        public string[] PLTEPLTEEntry { get; set; }
        public string[] collectorlocalFileaclALLOWREAD_NAMED_ATTRS { get; set; }
        public string tiffImageLength { get; set; }
        public string CompressionCompressionTypeName { get; set; }
        public string generator { get; set; }
        public string[] ChromaPalettePaletteEntry { get; set; }
        public DateTime dctermscreated { get; set; }
        public DateTime dctermsmodified { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime LastSaveDate { get; set; }
        public string content { get; set; }
        public string documentreference { get; set; }
        public string IHDR { get; set; }
        public string[] collectorlocalFileaclALLOWAPPEND_DATA { get; set; }
        public string[] collectorlocalFileaclALLOWSYNCHRONIZE { get; set; }
        public DateTime metasavedate { get; set; }
        public string collectoriscrawlnew { get; set; }
        public string EditTime { get; set; }
        public string nbObject { get; set; }
        public string ContentLength { get; set; }
        public string collectorlocalFileaclowner { get; set; }
        public string ObjectCount { get; set; }
        public object ContentType { get; set; }
        public string[] XParsedBy { get; set; }
        public string collectorcontentencoding { get; set; }
        public string[] collectorlocalFileaclALLOWDELETE { get; set; }
        public string CompressionNumProgressiveScans { get; set; }
        public string ChromaBlackIsZero { get; set; }
        public string width { get; set; }
        public string nbTab { get; set; }
        public string tiffImageWidth { get; set; }
        public string ChromaNumChannels { get; set; }
        public string TotalTime { get; set; }
        public string extendedpropertiesAppVersion { get; set; }
        public string metaparagraphcount { get; set; }
        public string subject { get; set; }
        public string WordCount { get; set; }
        public string metalinecount { get; set; }
        public string Template { get; set; }
        public string ParagraphCount { get; set; }
        public string metacharactercountwithspaces { get; set; }
        public string cpsubject { get; set; }
        public string metaauthor { get; set; }
        public string extendedpropertiesApplication { get; set; }
        public string CharacterCountWithSpaces { get; set; }
        public string LastAuthor { get; set; }
        public string CharacterCount { get; set; }
        public string PageCount { get; set; }
        public string ApplicationVersion { get; set; }
        public string extendedpropertiesTemplate { get; set; }
        public string Author { get; set; }
        public string publisher { get; set; }
        public string metapagecount { get; set; }
        public string cprevision { get; set; }
        public string metawordcount { get; set; }
        public string dccreator { get; set; }
        public string extendedpropertiesCompany { get; set; }
        public string metacharactercount { get; set; }
        public string LineCount { get; set; }
        public string ApplicationName { get; set; }
        public string extendedpropertiesTotalTime { get; set; }
        public string creator { get; set; }
        public string metalastauthor { get; set; }
        public string xmpTPgNPages { get; set; }
        public string RevisionNumber { get; set; }
        public string dcpublisher { get; set; }
        public string ContentLocation { get; set; }
        public string title { get; set; }
        public string samplefield { get; set; }
        public string dctitle { get; set; }
        public string contentlanguage { get; set; }
    }
}