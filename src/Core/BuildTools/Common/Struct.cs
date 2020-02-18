// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Common.Structs;

namespace Silk.NET.BuildTools.Common
{
    public class Struct
    {
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string ExtensionName { get; set; }
        [JsonIgnore] public string ProfileName { get; set; }
        [JsonIgnore] public Version ProfileVersion { get; set; }
        public List<Field> Fields { get; set; } = new List<Field>();
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();
        public List<ImplementedFunction> Functions { get; set; } = new List<ImplementedFunction>();
    }
}