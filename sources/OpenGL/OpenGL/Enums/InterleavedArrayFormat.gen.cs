// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum InterleavedArrayFormat : uint
{
    V2F = unchecked((uint)0x2A20),
    V3F = unchecked((uint)0x2A21),
    C4UbV2F = unchecked((uint)0x2A22),
    C4UbV3F = unchecked((uint)0x2A23),
    C3FV3F = unchecked((uint)0x2A24),
    N3FV3F = unchecked((uint)0x2A25),
    C4FN3FV3F = unchecked((uint)0x2A26),
    T2FV3F = unchecked((uint)0x2A27),
    T4FV4F = unchecked((uint)0x2A28),
    T2FC4UbV3F = unchecked((uint)0x2A29),
    T2FC3FV3F = unchecked((uint)0x2A2A),
    T2FN3FV3F = unchecked((uint)0x2A2B),
    T2FC4FN3FV3F = unchecked((uint)0x2A2C),
    T4FC4FN3FV4F = unchecked((uint)0x2A2D),
}
