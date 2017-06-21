using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GitHubStuff.Data
{
    public class GitHubFunctions
    {
        public GitHubUser GetUser(string login)
        {
            var url = $"https://api.github.com/users/{login}";

            using (var client = new WebClient())
            {
                client.Headers["User-Agent"] = "HEllo this is junk";
                string json = client.DownloadString(url);

                GitHubUser ghUser = JsonConvert.DeserializeObject<GitHubUser>(json);
                return ghUser;
            }
               
        }
        public IEnumerable<GitHubRepo> GetRepos(string login)
        {
            var url = $"https://api.github.com/users/{login}/repos";

            using (var client = new WebClient())
            {
                client.Headers["User-Agent"] = "HEllo this is junk";
                string json = client.DownloadString(url);

                IEnumerable<GitHubRepo> ghRepos = JsonConvert.DeserializeObject<IEnumerable<GitHubRepo>>(json);
                return ghRepos;
            }

        }
    }
}
