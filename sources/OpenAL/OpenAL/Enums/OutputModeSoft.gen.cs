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
[NativeName("OutputModeSOFT")]
[Transformed]
public enum OutputModeSoft : uint
{
    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_ANY_SOFT")]
    Anysoft = unchecked((uint)0x19AD),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_STEREO_BASIC_SOFT")]
    StereoBasicsoft = unchecked((uint)0x19AE),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_STEREO_UHJ_SOFT")]
    StereoUhjsoft = unchecked((uint)0x19AF),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_STEREO_HRTF_SOFT")]
    StereoHrtfsoft = unchecked((uint)0x19B2),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_SURROUND_5_1_SOFT")]
    Surround5X1Soft = unchecked((uint)0x1504),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_SURROUND_6_1_SOFT")]
    Surround6X1Soft = unchecked((uint)0x1505),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_SURROUND_7_1_SOFT")]
    Surround7X1Soft = unchecked((uint)0x1506),
}
