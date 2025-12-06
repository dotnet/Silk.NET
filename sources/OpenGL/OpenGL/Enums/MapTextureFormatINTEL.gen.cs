// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MapTextureFormatINTEL")]
public enum MapTextureFormatINTEL : uint
{
    [NativeName("GL_LAYOUT_DEFAULT_INTEL")]
    Default = 0,

    [NativeName("GL_LAYOUT_LINEAR_INTEL")]
    Linear = 1,

    [NativeName("GL_LAYOUT_LINEAR_CPU_CACHED_INTEL")]
    LinearCpuCached = 2,
}
