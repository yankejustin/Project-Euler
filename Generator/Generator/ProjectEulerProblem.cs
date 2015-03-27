using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class ProjectEulerProblem
    {
        public int ProblemNumber { get; set; }
        public string ProblemName { get; set; }
        public string ProblemDescription { get; set; }

        public string RawPageData { get; private set; }

        public ProjectEulerProblem()
        {

        }

        // TODO - Call an event to signal that this problem changed.
        public void SetRawData(string _RawPageData)
        {
            RawPageData = _RawPageData;

            ProblemNumber = -1;
            ProblemName = string.Empty;
            ProblemDescription = string.Empty;
        }

        // TODO - Parse the raw page data.
        public bool ParseRawData()
        {
            return true;
        }
    }
}