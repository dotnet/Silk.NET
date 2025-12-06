// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum CombinerMappingNV : uint
{
    UnsignedIdentity = unchecked((uint)0x8536),
    UnsignedInvert = unchecked((uint)0x8537),
    ExpandNormal = unchecked((uint)0x8538),
    ExpandNegate = unchecked((uint)0x8539),
    HalfBiasNormal = unchecked((uint)0x853A),
    HalfBiasNegate = unchecked((uint)0x853B),
    SignedIdentity = unchecked((uint)0x853C),
    SignedNegate = unchecked((uint)0x853D),
}
