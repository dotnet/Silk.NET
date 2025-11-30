// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("RenderingMode")]
[Transformed]
public enum RenderingMode : uint
{
    [NativeName("GL_RENDER")]
    Render = unchecked((uint)0x1C00),

    [NativeName("GL_FEEDBACK")]
    Feedback = unchecked((uint)0x1C01),

    [NativeName("GL_SELECT")]
    Select = unchecked((uint)0x1C02),
}
