using System;
using Nest;
using Optional;

namespace Data
{
    public class ElasticSearch
    {
        private ElasticClient _client;
        private string _index = "data35";

        private ElasticSearch()
        {
            var node = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(node).DefaultIndex(_index);
            _client = new ElasticClient(settings);
        }

        public Option<string, Exception> Index(object data, string type)
        {
            var result = _client.Index(data, x => x.Type(type));

            if (!result.IsValid)
            {
                return Option.None<string, Exception>(new InvalidOperationException($"Failed to write index: '{result.DebugInformation}'"));
            }

            return $"{_index}:{type}".Some<string, Exception>();
        }

        public static ElasticSearch Create() {
            return new ElasticSearch();
        }
    }
}