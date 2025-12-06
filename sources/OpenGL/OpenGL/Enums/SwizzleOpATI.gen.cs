// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SwizzleOpATI")]
public enum SwizzleOpATI : uint
{
    [NativeName("GL_SWIZZLE_STR_ATI")]
    Str = 35190,

    [NativeName("GL_SWIZZLE_STQ_ATI")]
    Stq = 35191,

    [NativeName("GL_SWIZZLE_STR_DR_ATI")]
    StrDr = 35192,

    [NativeName("GL_SWIZZLE_STQ_DQ_ATI")]
    StqDq = 35193,
}
