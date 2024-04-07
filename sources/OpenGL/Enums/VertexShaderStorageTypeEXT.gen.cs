// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexShaderStorageTypeEXT : uint
{
    Variant = 0x87C1,
    Invariant = 0x87C2,
    LocalConstant = 0x87C3,
    Local = 0x87C4
}
