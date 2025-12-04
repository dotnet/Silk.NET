// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

[NameAffix("Suffix", "SOFT", 0, -1)]
[NativeName("RenderFormatChannelSOFT")]
public enum RenderFormatChannelSOFT : uint
{
    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("ALC_MONO_SOFT")]
    Mono = unchecked((uint)0x1500),

    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("ALC_STEREO_SOFT")]
    Stereo = unchecked((uint)0x1501),

    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("ALC_QUAD_SOFT")]
    Quad = unchecked((uint)0x1503),

    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("ALC_5POINT1_SOFT")]
    X5Point1 = unchecked((uint)0x1504),

    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("ALC_6POINT1_SOFT")]
    X6Point1 = unchecked((uint)0x1505),

    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("ALC_7POINT1_SOFT")]
    X7Point1 = unchecked((uint)0x1506),

    [NameAffix("Suffix", "SOFT", -1, -1)]
    [NativeName("ALC_BFORMAT3D_SOFT")]
    Bformat3D = unchecked((uint)0x1507),
}
