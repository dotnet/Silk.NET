// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FragmentOp3ATI")]
public enum FragmentOp3ATI : uint
{
    [NativeName("GL_MAD_ATI")]
    MadATI = unchecked((uint)0x8968),

    [NativeName("GL_LERP_ATI")]
    LerpATI = unchecked((uint)0x8969),

    [NativeName("GL_CND_ATI")]
    CndATI = unchecked((uint)0x896A),

    [NativeName("GL_CND0_ATI")]
    Cnd0ATI = unchecked((uint)0x896B),

    [NativeName("GL_DOT2_ADD_ATI")]
    Dot2AddATI = unchecked((uint)0x896C),
}
