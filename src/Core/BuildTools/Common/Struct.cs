// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.BuildTools.Common.Structs;

namespace Silk.NET.BuildTools.Common
{
    public class Struct
    {
        public string Name { get; set; }
        public string NativeName { get; set; }
        public List<Field> Fields { get; set; }
    }
}
