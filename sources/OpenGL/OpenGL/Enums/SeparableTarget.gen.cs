// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SeparableTarget")]
[Transformed]
public enum SeparableTarget : uint
{
    [NativeName("GL_SEPARABLE_2D")]
    Separable2D = unchecked((uint)0x8012),
}
