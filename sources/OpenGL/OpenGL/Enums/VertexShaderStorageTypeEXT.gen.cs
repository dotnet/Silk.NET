// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexShaderStorageTypeEXT")]
public enum VertexShaderStorageTypeEXT : uint
{
    [NativeName("GL_VARIANT_EXT")]
    Variant = unchecked((uint)0x87C1),

    [NativeName("GL_INVARIANT_EXT")]
    Invariant = unchecked((uint)0x87C2),

    [NativeName("GL_LOCAL_CONSTANT_EXT")]
    LocalConstant = unchecked((uint)0x87C3),

    [NativeName("GL_LOCAL_EXT")]
    Local = unchecked((uint)0x87C4),
}
