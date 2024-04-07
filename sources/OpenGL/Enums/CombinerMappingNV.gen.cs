// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum CombinerMappingNV : uint
{
    UnsignedIdentity = 0x8536,
    UnsignedInvert = 0x8537,
    ExpandNormal = 0x8538,
    ExpandNegate = 0x8539,
    HalfBiasNormal = 0x853A,
    HalfBiasNegate = 0x853B,
    SignedIdentity = 0x853C,
    SignedNegate = 0x853D
}
