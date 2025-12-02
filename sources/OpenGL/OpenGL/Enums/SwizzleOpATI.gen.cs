// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", 0)]
[NativeName("SwizzleOpATI")]
public enum SwizzleOpATI : uint
{
    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_SWIZZLE_STR_ATI")]
    Str = unchecked((uint)0x8976),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_SWIZZLE_STQ_ATI")]
    Stq = unchecked((uint)0x8977),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_SWIZZLE_STR_DR_ATI")]
    StrDr = unchecked((uint)0x8978),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_SWIZZLE_STQ_DQ_ATI")]
    StqDq = unchecked((uint)0x8979),
}
