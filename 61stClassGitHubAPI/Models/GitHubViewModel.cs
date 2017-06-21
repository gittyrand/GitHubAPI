using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GitHubStuff.Data;

namespace _61stClassGitHubAPI.Models
{
    public class GitHubViewModel
    {
        public GitHubUser ghUser { get; set; }
        public IEnumerable<GitHubRepo> ghRepos { get; set; }

    }
}