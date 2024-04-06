// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum VertexHintsMaskPGI
{
    Color3Bit = 0x00010000,
    Color4Bit = 0x00020000,
    EdgeflagBit = 0x00040000,
    IndexBit = 0x00080000,
    MatAmbientBit = 0x00100000,
    MatAmbientAndDiffuseBit = 0x00200000,
    MatDiffuseBit = 0x00400000,
    MatEmissionBit = 0x00800000,
    MatColorIndexesBit = 0x01000000,
    MatShininessBit = 0x02000000,
    MatSpecularBit = 0x04000000,
    NormalBit = 0x08000000,
    Texcoord1Bit = 0x10000000,
    Texcoord2Bit = 0x20000000,
    Texcoord3Bit = 0x40000000,
    Texcoord4Bit = 0x80000000,
    Vertex23Bit = 0x00000004,
    Vertex4Bit = 0x00000008
}
