// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ArrayObjectUsageATI")]
    public enum ArrayObjectUsageATI : int
    {
        [NativeName("Name", "GL_STATIC_ATI")]
        StaticAti = 0x8760,
        [NativeName("Name", "GL_DYNAMIC_ATI")]
        DynamicAti = 0x8761,
    }
}
