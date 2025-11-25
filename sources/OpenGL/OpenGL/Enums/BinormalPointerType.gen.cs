// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum BinormalPointerType : uint
{
    Byte = unchecked((uint)0x1400),
    Short = unchecked((uint)0x1402),
    Int = unchecked((uint)0x1404),
    Float = unchecked((uint)0x1406),
    Double = unchecked((uint)0x140A),
}
