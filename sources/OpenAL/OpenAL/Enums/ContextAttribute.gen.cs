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

[Transformed]
public enum ContextAttribute : uint
{
    Frequency = unchecked((uint)0x1007),
    Refresh = unchecked((uint)0x1008),
    Sync = unchecked((uint)0x1009),
    MonoSources = unchecked((uint)0x1010),
    StereoSources = unchecked((uint)0x1011),
    FormatChannelsSOFT = unchecked((uint)0x1990),
    FormatTypeSOFT = unchecked((uint)0x1991),
    DefaultFilterOrder = unchecked((uint)0x1100),
    HrtfSOFT = unchecked((uint)0x1992),
    HrtfIdSOFT = unchecked((uint)0x1996),
    OutputLimiterSOFT = unchecked((uint)0x199A),
    AmbisonicLayoutSOFT = unchecked((uint)0x1997),
    AmbisonicScalingSOFT = unchecked((uint)0x1998),
    AmbisonicOrderSOFT = unchecked((uint)0x1999),
    OutputModeSOFT = unchecked((uint)0x19AC),
}
