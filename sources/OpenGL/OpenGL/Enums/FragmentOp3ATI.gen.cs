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
    Mad = 35176,

    [NativeName("GL_LERP_ATI")]
    Lerp = 35177,

    [NativeName("GL_CND_ATI")]
    Cnd = 35178,

    [NativeName("GL_CND0_ATI")]
    Cnd0 = 35179,

    [NativeName("GL_DOT2_ADD_ATI")]
    Dot2Add = 35180,
}
