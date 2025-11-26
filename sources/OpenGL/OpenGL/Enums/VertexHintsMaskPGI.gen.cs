// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
[Flags]
public enum VertexHintsMaskPGI : uint
{
    Color3Bit = unchecked((uint)0x00010000),
    Color4Bit = unchecked((uint)0x00020000),
    EdgeflagBit = unchecked((uint)0x00040000),
    IndexBit = unchecked((uint)0x00080000),
    MatAmbientBit = unchecked((uint)0x00100000),
    MatAmbientAndDiffuseBit = unchecked((uint)0x00200000),
    MatDiffuseBit = unchecked((uint)0x00400000),
    MatEmissionBit = unchecked((uint)0x00800000),
    MatColorIndexesBit = unchecked((uint)0x01000000),
    MatShininessBit = unchecked((uint)0x02000000),
    MatSpecularBit = unchecked((uint)0x04000000),
    NormalBit = unchecked((uint)0x08000000),
    Texcoord1Bit = unchecked((uint)0x10000000),
    Texcoord2Bit = unchecked((uint)0x20000000),
    Texcoord3Bit = unchecked((uint)0x40000000),
    Texcoord4Bit = unchecked((uint)0x80000000),
    Vertex23Bit = unchecked((uint)0x00000004),
    Vertex4Bit = unchecked((uint)0x00000008),
}
