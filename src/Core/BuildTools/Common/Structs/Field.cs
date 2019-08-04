// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common.Structs
{
    public class Field
    {
        public Type Type { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string NativeType { get; set; }
    }
}
