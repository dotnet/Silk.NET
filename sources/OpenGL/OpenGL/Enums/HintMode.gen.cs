// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("HintMode")]
[Transformed]
public enum HintMode : uint
{
    [NativeName("GL_DONT_CARE")]
    DontCare = unchecked((uint)0x1100),

    [NativeName("GL_FASTEST")]
    Fastest = unchecked((uint)0x1101),

    [NativeName("GL_NICEST")]
    Nicest = unchecked((uint)0x1102),
}
