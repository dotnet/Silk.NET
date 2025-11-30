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

[NameAffix("Suffix", "SOFT", 0)]
[NativeName("RenderFormatTypeSOFT")]
[Transformed]
public enum RenderFormatTypeSOFT : uint
{
    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_BYTE_SOFT")]
    ByteSOFT = unchecked((uint)0x1400),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_UNSIGNED_BYTE_SOFT")]
    UnsignedByteSOFT = unchecked((uint)0x1401),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_SHORT_SOFT")]
    ShortSOFT = unchecked((uint)0x1402),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_UNSIGNED_SHORT_SOFT")]
    UnsignedShortSOFT = unchecked((uint)0x1403),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_INT_SOFT")]
    IntSOFT = unchecked((uint)0x1404),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_UNSIGNED_INT_SOFT")]
    UnsignedIntSOFT = unchecked((uint)0x1405),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_FLOAT_SOFT")]
    FloatSOFT = unchecked((uint)0x1406),
}
