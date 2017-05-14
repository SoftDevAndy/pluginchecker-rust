using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustPluginChecker
{
    class Details
    {
        public string PluginName { get; set; }
        public string CurrentVersion {get;set;}
        public string LatestVersion { get; set; }
        public string Url { get; set;}

        public Details(string name, string curr, string latest, string url)
        {
            this.PluginName = name;
            this.CurrentVersion = curr;
            this.LatestVersion = latest;
            this.Url = url;
        }
    }
}
