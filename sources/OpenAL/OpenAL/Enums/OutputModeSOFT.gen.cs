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
    AnySOFT = unchecked((uint)0x19AD),

    [NativeName("ALC_STEREO_BASIC_SOFT")]
    StereoBasicSOFT = unchecked((uint)0x19AE),

    [NativeName("ALC_STEREO_UHJ_SOFT")]
    StereoUhjSOFT = unchecked((uint)0x19AF),

    [NativeName("ALC_STEREO_HRTF_SOFT")]
    StereoHrtfSOFT = unchecked((uint)0x19B2),

    [NativeName("ALC_SURROUND_5_1_SOFT")]
    Surround5X1SOFT = unchecked((uint)0x1504),

    [NativeName("ALC_SURROUND_6_1_SOFT")]
    Surround6X1SOFT = unchecked((uint)0x1505),

    [NativeName("ALC_SURROUND_7_1_SOFT")]
    Surround7X1SOFT = unchecked((uint)0x1506),
}
