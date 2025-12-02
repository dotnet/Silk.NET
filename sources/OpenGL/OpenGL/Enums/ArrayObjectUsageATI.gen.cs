// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", 0)]
[NativeName("ArrayObjectUsageATI")]
public enum ArrayObjectUsageATI : uint
{
    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_STATIC_ATI")]
    Static = unchecked((uint)0x8760),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_DYNAMIC_ATI")]
    Dynamic = unchecked((uint)0x8761),
}
