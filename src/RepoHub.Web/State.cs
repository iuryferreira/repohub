using System.Collections.Generic;
using RepoHub.Web.Models;

namespace RepoHub.Web
{
    public class State
    {
        public string Username { get; set; }
        public List<Repository> Repositories { get; set; }

        public State ()
        {
            Repositories = new();
        }
    }
}
