// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;

namespace Silk.NET.BuildTools.Converters
{
    public struct ProfileConverterOptions
    {
        public string Prefix { get; set; }
        public List<Dictionary<string, string>> TypeMaps { get; set; }
    }
}
