// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelStoreSubsampleRate")]
[Transformed]
public enum PixelStoreSubsampleRate : uint
{
    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_SUBSAMPLE_4444_SGIX")]
    Subsample4444SGIX = unchecked((uint)0x85A2),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_SUBSAMPLE_2424_SGIX")]
    Subsample2424SGIX = unchecked((uint)0x85A3),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_PIXEL_SUBSAMPLE_4242_SGIX")]
    Subsample4242SGIX = unchecked((uint)0x85A4),
}
