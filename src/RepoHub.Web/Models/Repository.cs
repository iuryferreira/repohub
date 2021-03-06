using System;
using System.Text.Json.Serialization;

namespace RepoHub.Web.Models
{
    public class Repository
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonPropertyName("name")]
        public string Name { get; init; }

        [JsonPropertyName("description")]
        public string Description { get; init; }

        [JsonPropertyName("html_url")]
        public string Url { get; init; }

        [JsonPropertyName("pushed_at")]
        public DateTime PushedAt { get; init; }

    }
}
