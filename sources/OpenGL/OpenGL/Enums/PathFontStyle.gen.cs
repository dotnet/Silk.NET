// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathFontStyle")]
[Flags]
public enum PathFontStyle : uint
{
    [NativeName("GL_NONE")]
    None = 0x0,

    [NativeName("GL_BOLD_BIT_NV")]
    BoldBitNV = 0x1,

    [NativeName("GL_ITALIC_BIT_NV")]
    ItalicBitNV = 0x2,
}
