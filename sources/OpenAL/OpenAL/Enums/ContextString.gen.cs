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
public enum ContextString : uint
{
    [NativeName("ALC_DEFAULT_DEVICE_SPECIFIER")]
    DefaultDeviceSpecifier = 4100,

    [NativeName("ALC_DEVICE_SPECIFIER")]
    DeviceSpecifier = 4101,

    [NativeName("ALC_EXTENSIONS")]
    Extensions = 4102,

    [NativeName("ALC_CAPTURE_DEVICE_SPECIFIER")]
    CaptureDeviceSpecifier = 784,

    [NativeName("ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER")]
    CaptureDefaultDeviceSpecifier = 785,

    [NativeName("ALC_DEFAULT_ALL_DEVICES_SPECIFIER")]
    DefaultAllDevicesSpecifier = 4114,

    [NativeName("ALC_ALL_DEVICES_SPECIFIER")]
    AllDevicesSpecifier = 4115,

    [NativeName("ALC_HRTF_SPECIFIER_SOFT")]
    HrtfSpecifierSOFT = 6549,
}
