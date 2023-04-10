using System.Text.Json.Serialization;

namespace DaddyJokesWebApp.Models
{
    /// <summary>
    /// Joke model class to store daddyjokes jokecount data.
    /// </summary>
    public class JokeCount
    {
        public int Body { get; set; }
        [JsonPropertyName("sucess")]
        public bool Success { get; set; }

    }
}
