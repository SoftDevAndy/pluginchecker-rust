using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustPluginChecker
{
    class RustPluginRefList
    {
        [JsonProperty(PropertyName = "PluginList")]
        public List<PluginRef> allPluginsRef { get; set; }
    }
}
