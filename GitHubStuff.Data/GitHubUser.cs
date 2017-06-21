using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubStuff.Data
{
    public class GitHubUser
    {
        public string login { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string location { get; set; }
        //public IEnumerable<GitHubRepo> gitHubRepos { get; set; }
    }
}
