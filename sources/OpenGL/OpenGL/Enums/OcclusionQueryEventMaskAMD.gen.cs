// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
[Flags]
public enum OcclusionQueryEventMaskAMD : uint
{
    DepthPassEventBit = unchecked((uint)0x00000001),
    DepthFailEventBit = unchecked((uint)0x00000002),
    StencilFailEventBit = unchecked((uint)0x00000004),
    DepthBoundsFailEventBit = unchecked((uint)0x00000008),
    AllEventBits = unchecked((uint)0xFFFFFFFF),
}
