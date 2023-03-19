// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "MapTextureFormatINTEL")]
    public enum MapTextureFormatINTEL : int
    {
        [Obsolete("Deprecated in favour of \"DefaultIntel\"")]
        [NativeName("Name", "GL_LAYOUT_DEFAULT_INTEL")]
        LayoutDefaultIntel = 0x0,
        [Obsolete("Deprecated in favour of \"LinearIntel\"")]
        [NativeName("Name", "GL_LAYOUT_LINEAR_INTEL")]
        LayoutLinearIntel = 0x1,
        [Obsolete("Deprecated in favour of \"LinearCpuCachedIntel\"")]
        [NativeName("Name", "GL_LAYOUT_LINEAR_CPU_CACHED_INTEL")]
        LayoutLinearCpuCachedIntel = 0x2,
        [NativeName("Name", "GL_LAYOUT_DEFAULT_INTEL")]
        DefaultIntel = 0x0,
        [NativeName("Name", "GL_LAYOUT_LINEAR_INTEL")]
        LinearIntel = 0x1,
        [NativeName("Name", "GL_LAYOUT_LINEAR_CPU_CACHED_INTEL")]
        LinearCpuCachedIntel = 0x2,
    }
}
