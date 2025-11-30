// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TexStorageAttribs")]
[Transformed]
public enum TexStorageAttribs : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_EXT")]
    Ext = unchecked((uint)0x96C0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_NONE_EXT")]
    FixedRateNoneext = unchecked((uint)0x96C1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
    FixedRateDefaultext = unchecked((uint)0x96C2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_1BPC_EXT")]
    FixedRate1Bpcext = unchecked((uint)0x96C4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_2BPC_EXT")]
    FixedRate2Bpcext = unchecked((uint)0x96C5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_3BPC_EXT")]
    FixedRate3Bpcext = unchecked((uint)0x96C6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_4BPC_EXT")]
    FixedRate4Bpcext = unchecked((uint)0x96C7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_5BPC_EXT")]
    FixedRate5Bpcext = unchecked((uint)0x96C8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_6BPC_EXT")]
    FixedRate6Bpcext = unchecked((uint)0x96C9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_7BPC_EXT")]
    FixedRate7Bpcext = unchecked((uint)0x96CA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_8BPC_EXT")]
    FixedRate8Bpcext = unchecked((uint)0x96CB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_9BPC_EXT")]
    FixedRate9Bpcext = unchecked((uint)0x96CC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_10BPC_EXT")]
    FixedRate10Bpcext = unchecked((uint)0x96CD),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_11BPC_EXT")]
    FixedRate11Bpcext = unchecked((uint)0x96CE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SURFACE_COMPRESSION_FIXED_RATE_12BPC_EXT")]
    FixedRate12Bpcext = unchecked((uint)0x96CF),
}
