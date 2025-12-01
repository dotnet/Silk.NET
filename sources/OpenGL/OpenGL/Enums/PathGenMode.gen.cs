// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathGenMode")]
public enum PathGenMode : uint
{
    [NativeName("GL_CONSTANT")]
    Constant = unchecked((uint)0x8576),

    [NativeName("GL_NONE")]
    None = unchecked((uint)0),

    [NativeName("GL_EYE_LINEAR")]
    EyeLinear = unchecked((uint)0x2400),

    [NativeName("GL_OBJECT_LINEAR")]
    ObjectLinear = unchecked((uint)0x2401),

    [NativeName("GL_PATH_OBJECT_BOUNDING_BOX_NV")]
    PathObjectBoundingBoxNV = unchecked((uint)0x908A),
}
