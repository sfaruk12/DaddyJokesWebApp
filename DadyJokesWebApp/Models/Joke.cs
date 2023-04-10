using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DaddyJokesWebApp.Models
{
    /// <summary>
    /// Joke model class to store daddyjokes joke data.
    /// </summary>
    public class Joke
    {
        [JsonPropertyName("body")]
        public Body [] Body { get; set; }
        [JsonPropertyName("sucess")]
        public bool Success { get; set; }
    }
    public class Body
    {
        [DisplayName("Id")]
        public string _id { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("setup")]
        public string Setup { get; set; }
        [JsonPropertyName("punchline")]
        public string Punchline { get; set; }
    }
}
