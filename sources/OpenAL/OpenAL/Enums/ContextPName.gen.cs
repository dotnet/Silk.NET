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

[NativeName("ContextPName")]
public enum ContextPName : uint
{
    [NativeName("ALC_FREQUENCY")]
    Frequency = 4103,

    [NativeName("ALC_REFRESH")]
    Refresh = 4104,

    [NativeName("ALC_SYNC")]
    Sync = 4105,

    [NativeName("ALC_MAJOR_VERSION")]
    MajorVersion = 4096,

    [NativeName("ALC_MINOR_VERSION")]
    MinorVersion = 4097,

    [NativeName("ALC_ATTRIBUTES_SIZE")]
    AttributesSize = 4098,

    [NativeName("ALC_ALL_ATTRIBUTES")]
    AllAttributes = 4099,

    [NativeName("ALC_DEFAULT_DEVICE_SPECIFIER")]
    DefaultDeviceSpecifier = 4100,

    [NativeName("ALC_DEVICE_SPECIFIER")]
    DeviceSpecifier = 4101,

    [NativeName("ALC_EXTENSIONS")]
    Extensions = 4102,

    [NativeName("ALC_MONO_SOURCES")]
    MonoSources = 4112,

    [NativeName("ALC_STEREO_SOURCES")]
    StereoSources = 4113,

    [NativeName("ALC_CAPTURE_DEVICE_SPECIFIER")]
    CaptureDeviceSpecifier = 784,

    [NativeName("ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER")]
    CaptureDefaultDeviceSpecifier = 785,

    [NativeName("ALC_CAPTURE_SAMPLES")]
    CaptureSamples = 786,

    [NativeName("ALC_DEFAULT_ALL_DEVICES_SPECIFIER")]
    DefaultAllDevicesSpecifier = 4114,

    [NativeName("ALC_ALL_DEVICES_SPECIFIER")]
    AllDevicesSpecifier = 4115,

    [NativeName("ALC_CONNECTED")]
    Connected = 787,

    [NativeName("ALC_DEFAULT_FILTER_ORDER")]
    DefaultFilterOrder = 4352,

    [NativeName("ALC_HRTF_SOFT")]
    HrtfSOFT = 6546,

    [NativeName("ALC_HRTF_STATUS_SOFT")]
    HrtfStatusSOFT = 6547,

    [NativeName("ALC_NUM_HRTF_SPECIFIERS_SOFT")]
    NumHrtfSpecifiersSOFT = 6548,

    [NativeName("ALC_HRTF_SPECIFIER_SOFT")]
    HrtfSpecifierSOFT = 6549,

    [NativeName("ALC_OUTPUT_LIMITER_SOFT")]
    OutputLimiterSOFT = 6554,

    [NativeName("ALC_DEVICE_CLOCK_SOFT")]
    DeviceClockSOFT = 5632,

    [NativeName("ALC_DEVICE_LATENCY_SOFT")]
    DeviceLatencySOFT = 5633,

    [NativeName("ALC_DEVICE_CLOCK_LATENCY_SOFT")]
    DeviceClockLatencySOFT = 5634,

    [NativeName("ALC_MAX_AMBISONIC_ORDER_SOFT")]
    MaxAmbisonicOrderSOFT = 6555,

    [NativeName("ALC_OUTPUT_MODE_SOFT")]
    OutputModeSOFT = 6572,

    [NativeName("ALC_CONTEXT_FLAGS_EXT")]
    ContextFlagsEXT = 6607,
}
