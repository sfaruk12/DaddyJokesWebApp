using DaddyJokesWebApp.Models;
using System.Collections;
using System.Threading.Tasks;

namespace DaddyJokesWebApp.Services
{
    public interface IDaddyJokeservice
    {
        Task<Joke> GetRandomJoke();
        Task<JokeCount> GetRandomJokeCount();
    }
}
