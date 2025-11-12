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
public enum ContextPName : uint
{
    Frequency = unchecked((uint)0x1007),
    Refresh = unchecked((uint)0x1008),
    Sync = unchecked((uint)0x1009),
    MajorVersion = unchecked((uint)0x1000),
    MinorVersion = unchecked((uint)0x1001),
    AttributesSize = unchecked((uint)0x1002),
    AllAttributes = unchecked((uint)0x1003),
    DefaultDeviceSpecifier = unchecked((uint)0x1004),
    DeviceSpecifier = unchecked((uint)0x1005),
    Extensions = unchecked((uint)0x1006),
    MonoSources = unchecked((uint)0x1010),
    StereoSources = unchecked((uint)0x1011),
    CaptureDeviceSpecifier = unchecked((uint)0x310),
    CaptureDefaultDeviceSpecifier = unchecked((uint)0x311),
    CaptureSamples = unchecked((uint)0x312),
    DefaultAllDevicesSpecifier = unchecked((uint)0x1012),
    AllDevicesSpecifier = unchecked((uint)0x1013),
    Connected = unchecked((uint)0x313),
    DefaultFilterOrder = unchecked((uint)0x1100),
    HrtfSOFT = unchecked((uint)0x1992),
    HrtfStatusSOFT = unchecked((uint)0x1993),
    NumHrtfSpecifiersSOFT = unchecked((uint)0x1994),
    HrtfSpecifierSOFT = unchecked((uint)0x1995),
    OutputLimiterSOFT = unchecked((uint)0x199A),
    DeviceClockSOFT = unchecked((uint)0x1600),
    DeviceLatencySOFT = unchecked((uint)0x1601),
    DeviceClockLatencySOFT = unchecked((uint)0x1602),
    MaxAmbisonicOrderSOFT = unchecked((uint)0x199B),
    OutputModeSOFT = unchecked((uint)0x19AC),
    ContextFlagsEXT = unchecked((uint)0x19CF),
}
