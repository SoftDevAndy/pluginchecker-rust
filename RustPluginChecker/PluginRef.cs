using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustPluginChecker
{
    class PluginRef
    {
        [JsonProperty(PropertyName = "name")]
        public String name { get; set; }
        [JsonProperty(PropertyName = "link")]
        public String link { get; set; }
    }
}
