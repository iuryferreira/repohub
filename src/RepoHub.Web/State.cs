using System.Collections.Generic;
using RepoHub.Web.Models;

namespace RepoHub.Web
{
    public class State
    {
        public State ()
        {
            Repositories = new();
        }

        public string Username { get; set; }
        public List<Repository> Repositories { get; set; }
        public int Count => Repositories.Count;

    }
}
