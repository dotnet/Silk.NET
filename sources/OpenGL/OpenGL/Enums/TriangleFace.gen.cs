// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TriangleFace")]
public enum TriangleFace : uint
{
    [NativeName("GL_FRONT")]
    Front = unchecked((uint)0x0404),

    [NativeName("GL_BACK")]
    Back = unchecked((uint)0x0405),

    [NativeName("GL_FRONT_AND_BACK")]
    FrontAndBack = unchecked((uint)0x0408),
}
