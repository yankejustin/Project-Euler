using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Generator
{
    public static class ProjectEulerFactory
    {
        public const Uri ProjectBaseUri = new Uri("https://projecteuler.net");

        // Eventually move outside of here and place elsewhere.
        // TODO - Add the ability to change where the projects are saved.
        public const string DirectoryFolder = @"Project Euler Problems\";

        public static IEnumerable<ProjectEulerProblem> GetAllProblems()
        {
            for (int i = 0; i < 501; i++)
            {
                // Will not work yet.
                // PageName example: "https://projecteuler.net/problem=" + i.ToString();
                // I just need to put it in a property that will modify the problem number
                //   if it is already set.
                string PageName = i.ToString();

                HttpWebRequest PageWebRequest = (HttpWebRequest)WebRequest.Create(ProjectBaseUri);
                PageWebRequest.UserAgent = @"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.1.5) Gecko/20091102 Firefox/3.5.5";
                PageWebRequest.Proxy = null;

                using (HttpWebResponse response = (HttpWebResponse)PageWebRequest.GetResponse())
                {
                    using (StreamReader ResponseStream = new StreamReader(response.GetResponseStream()))
                    {
                        yield return new ProjectEulerProblem()
                        {
                        };
                    }
                }
            }
        }
    }
}