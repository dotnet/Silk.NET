// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "APPLE", 0)]
[NativeName("ObjectTypeAPPLE")]
[Transformed]
public enum ObjectTypeAPPLE : uint
{
    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_DRAW_PIXELS_APPLE")]
    DrawPixelsAPPLE = unchecked((uint)0x8A0A),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_FENCE_APPLE")]
    FenceAPPLE = unchecked((uint)0x8A0B),
}
