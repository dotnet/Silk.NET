// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MapAttribParameterNV")]
public enum MapAttribParameterNV : uint
{
    [NativeName("GL_MAP_ATTRIB_U_ORDER_NV")]
    UOrderNV = unchecked((uint)0x86C3),

    [NativeName("GL_MAP_ATTRIB_V_ORDER_NV")]
    VOrderNV = unchecked((uint)0x86C4),
}
