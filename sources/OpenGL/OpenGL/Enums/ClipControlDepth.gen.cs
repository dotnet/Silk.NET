// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ClipControlDepth")]
[Transformed]
public enum ClipControlDepth : uint
{
    [NativeName("GL_NEGATIVE_ONE_TO_ONE")]
    NegativeOneToOne = unchecked((uint)0x935E),

    [NativeName("GL_ZERO_TO_ONE")]
    ZeroToOne = unchecked((uint)0x935F),
}
