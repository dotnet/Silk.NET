// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelStoreResampleMode")]
[Transformed]
public enum PixelStoreResampleMode : uint
{
    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_RESAMPLE_REPLICATE_SGIX")]
    Replicatesgix = unchecked((uint)0x8433),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_RESAMPLE_ZERO_FILL_SGIX")]
    ZeroFillsgix = unchecked((uint)0x8434),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_RESAMPLE_DECIMATE_SGIX")]
    Decimatesgix = unchecked((uint)0x8430),
}
