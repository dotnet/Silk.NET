// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Silk.NET.NUKE.SshAgent
{
    public class Configuration
    {
        public static Configuration FromJson(string json) => JsonSerializer.Deserialize<Configuration>(json);
        
        [JsonPropertyName("ip")]
        public string IpAddress { get; set; }
        
        [JsonPropertyName("http")]
        public ushort HttpPort { get; set; }
        
        [JsonPropertyName("ssh")]
        public ushort SshPort { get; set; }
        
        [JsonPropertyName("username")]
        public string SshUsername { get; set; }
        
        [JsonPropertyName("password")]
        public string SshPassword { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
