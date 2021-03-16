// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "MapTextureFormatINTEL")]
    public enum MapTextureFormatINTEL : int
    {
        [NativeName("Name", "GL_LAYOUT_DEFAULT_INTEL")]
        LayoutDefaultIntel = 0x0,
        [NativeName("Name", "GL_LAYOUT_LINEAR_INTEL")]
        LayoutLinearIntel = 0x1,
        [NativeName("Name", "GL_LAYOUT_LINEAR_CPU_CACHED_INTEL")]
        LayoutLinearCpuCachedIntel = 0x2,
    }
}
