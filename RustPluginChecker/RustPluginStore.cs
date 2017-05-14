using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustPluginChecker
{
    class RustPluginStore
    {
        public RustPluginStore(string sitename, string siteurl)
        {
            this.sitename = sitename;
            this.siteurl = siteurl;
        }

        [JsonProperty("sitename")]
        public string sitename { get; set; }
        [JsonProperty("siteurl")]
        public string siteurl { get; set; }
    }
}
