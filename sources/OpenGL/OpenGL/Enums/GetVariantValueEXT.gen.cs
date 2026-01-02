// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum GetVariantValueEXT : uint
{
    Value = unchecked((uint)0x87E4),
    Datatype = unchecked((uint)0x87E5),
    ArrayStride = unchecked((uint)0x87E6),
    ArrayType = unchecked((uint)0x87E7),
}
