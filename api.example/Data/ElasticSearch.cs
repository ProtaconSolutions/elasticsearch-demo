using System;
using Nest;
using Optional;
using Util;

namespace Data
{
    public class ElasticSearch
    {
        private ElasticClient _client;
        private string _index = "data";

        private ElasticSearch()
        {
            var node = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(node).DefaultIndex(_index);
            _client = new ElasticClient(settings);
        }

        public Option<string, ErrorString> Index(object data, string type)
        {
            var result = _client.Index(data, x => x.Type(type).Id(Guid.NewGuid()));

            if (!result.IsValid)
            {
                return Option.None<string, ErrorString>($"Failed to write index: '{result.DebugInformation}'");
            }

            return $"{_index}:{type}:{result.Id}".Some<string, ErrorString>();
        }

        public static ElasticSearch Create()
        {
            return new ElasticSearch();
        }
    }
}