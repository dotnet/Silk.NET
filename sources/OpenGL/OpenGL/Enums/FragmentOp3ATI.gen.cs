// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ATI", 0)]
[NativeName("FragmentOp3ATI")]
public enum FragmentOp3ATI : uint
{
    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_MAD_ATI")]
    Mad = unchecked((uint)0x8968),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_LERP_ATI")]
    Lerp = unchecked((uint)0x8969),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_CND_ATI")]
    Cnd = unchecked((uint)0x896A),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_CND0_ATI")]
    Cnd0 = unchecked((uint)0x896B),

    [NameAffix("Suffix", "ATI", -1)]
    [NativeName("GL_DOT2_ADD_ATI")]
    Dot2Add = unchecked((uint)0x896C),
}
