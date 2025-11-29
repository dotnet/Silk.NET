// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexShaderStorageTypeEXT : uint
{
    Variant = unchecked((uint)0x87C1),
    Invariant = unchecked((uint)0x87C2),
    LocalConstant = unchecked((uint)0x87C3),
    Local = unchecked((uint)0x87C4),
}
