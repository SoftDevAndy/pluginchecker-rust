using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustPluginChecker
{
    class RustPlugin
    {
        public string version { get; set; }
        public string name { get; set; }
        public string oxideUrl { get; set; }

        public RustPlugin(string name, string version)
        {
            this.version = version;
            this.name = name;
        }

        public RustPlugin(string name, string version, string oxideUrl) {
            this.version = version;
            this.name = name;
            this.oxideUrl = oxideUrl;
        }
    }
}
