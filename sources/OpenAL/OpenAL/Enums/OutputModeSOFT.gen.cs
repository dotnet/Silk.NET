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

[NativeName("OutputModeSOFT")]
public enum OutputModeSOFT : uint
{
    [NativeName("ALC_ANY_SOFT")]
    Any = 6573,

    [NativeName("ALC_STEREO_BASIC_SOFT")]
    StereoBasic = 6574,

    [NativeName("ALC_STEREO_UHJ_SOFT")]
    StereoUhj = 6575,

    [NativeName("ALC_STEREO_HRTF_SOFT")]
    StereoHrtf = 6578,

    [NativeName("ALC_SURROUND_5_1_SOFT")]
    Surround5X1 = 5380,

    [NativeName("ALC_SURROUND_6_1_SOFT")]
    Surround6X1 = 5381,

    [NativeName("ALC_SURROUND_7_1_SOFT")]
    Surround7X1 = 5382,
}
