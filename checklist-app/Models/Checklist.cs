using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace checklist_app.Models
{
    public class Item
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("hasvalue")]
        public bool HasValue { get; set; }
    }

    public class Flow
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

    }

    public class Checklist
    {
        [JsonPropertyName("aircraft")]
        public string Aircraft { get; set; }

        [JsonPropertyName("flows")]
        public List<Flow> Flows { get; set; }
    }
}
