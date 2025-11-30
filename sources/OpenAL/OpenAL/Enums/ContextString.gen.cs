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

[NativeName("ContextString")]
[Transformed]
public enum ContextString : uint
{
    [NativeName("ALC_DEFAULT_DEVICE_SPECIFIER")]
    DefaultDeviceSpecifier = unchecked((uint)0x1004),

    [NativeName("ALC_DEVICE_SPECIFIER")]
    DeviceSpecifier = unchecked((uint)0x1005),

    [NativeName("ALC_EXTENSIONS")]
    Extensions = unchecked((uint)0x1006),

    [NativeName("ALC_CAPTURE_DEVICE_SPECIFIER")]
    CaptureDeviceSpecifier = unchecked((uint)0x310),

    [NativeName("ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER")]
    CaptureDefaultDeviceSpecifier = unchecked((uint)0x311),

    [NativeName("ALC_DEFAULT_ALL_DEVICES_SPECIFIER")]
    DefaultAllDevicesSpecifier = unchecked((uint)0x1012),

    [NativeName("ALC_ALL_DEVICES_SPECIFIER")]
    AllDevicesSpecifier = unchecked((uint)0x1013),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_SPECIFIER_SOFT")]
    HrtfSpecifierSOFT = unchecked((uint)0x1995),
}
