// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ArrayObjectPNameATI")]
    public enum ArrayObjectPNameATI
    {
        [NativeName("Name", "GL_OBJECT_BUFFER_SIZE_ATI")]
        ObjectBufferSizeAti = 0x8764,
        [NativeName("Name", "GL_OBJECT_BUFFER_USAGE_ATI")]
        ObjectBufferUsageAti = 0x8765,
    }
}
