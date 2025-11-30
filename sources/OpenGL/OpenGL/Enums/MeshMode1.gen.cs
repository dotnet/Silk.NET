// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MeshMode1")]
[Transformed]
public enum MeshMode1 : uint
{
    [NativeName("GL_POINT")]
    Point = unchecked((uint)0x1B00),

    [NativeName("GL_LINE")]
    Line = unchecked((uint)0x1B01),
}
