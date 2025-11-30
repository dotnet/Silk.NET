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

[NativeName("ALCEnum")]
[Transformed]
public enum AlcEnum : uint
{
    [NativeName("ALC_INVALID")]
    Invalid = unchecked((uint)0),

    [NativeName("ALC_FALSE")]
    False = unchecked((uint)0),

    [NativeName("ALC_TRUE")]
    True = unchecked((uint)1),

    [NativeName("ALC_FREQUENCY")]
    Frequency = unchecked((uint)0x1007),

    [NativeName("ALC_REFRESH")]
    Refresh = unchecked((uint)0x1008),

    [NativeName("ALC_SYNC")]
    Sync = unchecked((uint)0x1009),

    [NativeName("ALC_NO_ERROR")]
    NoError = unchecked((uint)0),

    [NativeName("ALC_INVALID_DEVICE")]
    InvalidDevice = unchecked((uint)0xA001),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("ALC_INVALID_CONTEXT")]
    InvalidContext = unchecked((uint)0xA002),

    [NativeName("ALC_INVALID_ENUM")]
    InvalidEnum = unchecked((uint)0xA003),

    [NativeName("ALC_INVALID_VALUE")]
    InvalidValue = unchecked((uint)0xA004),

    [NativeName("ALC_OUT_OF_MEMORY")]
    OutOfMemory = unchecked((uint)0xA005),

    [NativeName("ALC_MAJOR_VERSION")]
    MajorVersion = unchecked((uint)0x1000),

    [NativeName("ALC_MINOR_VERSION")]
    MinorVersion = unchecked((uint)0x1001),

    [NativeName("ALC_ATTRIBUTES_SIZE")]
    AttributesSize = unchecked((uint)0x1002),

    [NativeName("ALC_ALL_ATTRIBUTES")]
    AllAttributes = unchecked((uint)0x1003),

    [NativeName("ALC_DEFAULT_DEVICE_SPECIFIER")]
    DefaultDeviceSpecifier = unchecked((uint)0x1004),

    [NativeName("ALC_DEVICE_SPECIFIER")]
    DeviceSpecifier = unchecked((uint)0x1005),

    [NativeName("ALC_EXTENSIONS")]
    Extensions = unchecked((uint)0x1006),

    [NativeName("ALC_MONO_SOURCES")]
    MonoSources = unchecked((uint)0x1010),

    [NativeName("ALC_STEREO_SOURCES")]
    StereoSources = unchecked((uint)0x1011),

    [NativeName("ALC_CAPTURE_DEVICE_SPECIFIER")]
    CaptureDeviceSpecifier = unchecked((uint)0x310),

    [NativeName("ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER")]
    CaptureDefaultDeviceSpecifier = unchecked((uint)0x311),

    [NativeName("ALC_CAPTURE_SAMPLES")]
    CaptureSamples = unchecked((uint)0x312),

    [NativeName("ALC_DEFAULT_ALL_DEVICES_SPECIFIER")]
    DefaultAllDevicesSpecifier = unchecked((uint)0x1012),

    [NativeName("ALC_ALL_DEVICES_SPECIFIER")]
    AllDevicesSpecifier = unchecked((uint)0x1013),

    [NameAffix("Suffix", "LOKI", 0)]
    [NativeName("ALC_CHAN_MAIN_LOKI")]
    ChanMainloki = unchecked((uint)0x500001),

    [NameAffix("Suffix", "LOKI", 0)]
    [NativeName("ALC_CHAN_PCM_LOKI")]
    ChanPcmloki = unchecked((uint)0x500002),

    [NameAffix("Suffix", "LOKI", 0)]
    [NativeName("ALC_CHAN_CD_LOKI")]
    ChanCdloki = unchecked((uint)0x500003),

    [NativeName("ALC_EFX_MAJOR_VERSION")]
    EfxMajorVersion = unchecked((uint)0x20001),

    [NativeName("ALC_EFX_MINOR_VERSION")]
    EfxMinorVersion = unchecked((uint)0x20002),

    [NativeName("ALC_MAX_AUXILIARY_SENDS")]
    MaxAuxiliarySends = unchecked((uint)0x20003),

    [NativeName("ALC_CONNECTED")]
    Connected = unchecked((uint)0x313),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_FORMAT_CHANNELS_SOFT")]
    FormatChannelssoft = unchecked((uint)0x1990),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_FORMAT_TYPE_SOFT")]
    FormatTypesoft = unchecked((uint)0x1991),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_BYTE_SOFT")]
    Bytesoft = unchecked((uint)0x1400),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_UNSIGNED_BYTE_SOFT")]
    UnsignedBytesoft = unchecked((uint)0x1401),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_SHORT_SOFT")]
    Shortsoft = unchecked((uint)0x1402),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_UNSIGNED_SHORT_SOFT")]
    UnsignedShortsoft = unchecked((uint)0x1403),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_INT_SOFT")]
    Intsoft = unchecked((uint)0x1404),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_UNSIGNED_INT_SOFT")]
    UnsignedIntsoft = unchecked((uint)0x1405),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_FLOAT_SOFT")]
    Floatsoft = unchecked((uint)0x1406),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_MONO_SOFT")]
    Monosoft = unchecked((uint)0x1500),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_STEREO_SOFT")]
    Stereosoft = unchecked((uint)0x1501),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_QUAD_SOFT")]
    Quadsoft = unchecked((uint)0x1503),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_5POINT1_SOFT")]
    X5Point1Soft = unchecked((uint)0x1504),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_6POINT1_SOFT")]
    X6Point1Soft = unchecked((uint)0x1505),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_7POINT1_SOFT")]
    X7Point1Soft = unchecked((uint)0x1506),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_SOFT")]
    Hrtfsoft = unchecked((uint)0x1992),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_DONT_CARE_SOFT")]
    DontCaresoft = unchecked((uint)0x0002),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_STATUS_SOFT")]
    HrtfStatussoft = unchecked((uint)0x1993),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_DISABLED_SOFT")]
    HrtfDisabledsoft = unchecked((uint)0x0000),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_ENABLED_SOFT")]
    HrtfEnabledsoft = unchecked((uint)0x0001),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_DENIED_SOFT")]
    HrtfDeniedsoft = unchecked((uint)0x0002),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_REQUIRED_SOFT")]
    HrtfRequiredsoft = unchecked((uint)0x0003),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_HEADPHONES_DETECTED_SOFT")]
    HrtfHeadphonesDetectedsoft = unchecked((uint)0x0004),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_UNSUPPORTED_FORMAT_SOFT")]
    HrtfUnsupportedFormatsoft = unchecked((uint)0x0005),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_NUM_HRTF_SPECIFIERS_SOFT")]
    NumHrtfSpecifierssoft = unchecked((uint)0x1994),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_SPECIFIER_SOFT")]
    HrtfSpecifiersoft = unchecked((uint)0x1995),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_HRTF_ID_SOFT")]
    HrtfIdsoft = unchecked((uint)0x1996),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_OUTPUT_LIMITER_SOFT")]
    OutputLimitersoft = unchecked((uint)0x199A),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_DEVICE_CLOCK_SOFT")]
    DeviceClocksoft = unchecked((uint)0x1600),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_DEVICE_LATENCY_SOFT")]
    DeviceLatencysoft = unchecked((uint)0x1601),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_DEVICE_CLOCK_LATENCY_SOFT")]
    DeviceClockLatencysoft = unchecked((uint)0x1602),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_AMBISONIC_LAYOUT_SOFT")]
    AmbisonicLayoutsoft = unchecked((uint)0x1997),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_AMBISONIC_SCALING_SOFT")]
    AmbisonicScalingsoft = unchecked((uint)0x1998),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_AMBISONIC_ORDER_SOFT")]
    AmbisonicOrdersoft = unchecked((uint)0x1999),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_MAX_AMBISONIC_ORDER_SOFT")]
    MaxAmbisonicOrdersoft = unchecked((uint)0x199B),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_BFORMAT3D_SOFT")]
    Bformat3Dsoft = unchecked((uint)0x1507),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_FUMA_SOFT")]
    Fumasoft = unchecked((uint)0x0000),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_ACN_SOFT")]
    Acnsoft = unchecked((uint)0x0001),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_SN3D_SOFT")]
    Sn3Dsoft = unchecked((uint)0x0001),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_N3D_SOFT")]
    N3Dsoft = unchecked((uint)0x0002),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_OUTPUT_MODE_SOFT")]
    OutputModesoft = unchecked((uint)0x19AC),

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

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("ALC_CONTEXT_FLAGS_EXT")]
    ContextFlagsext = unchecked((uint)0x19CF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("ALC_CONTEXT_DEBUG_BIT_EXT")]
    ContextDebugBitext = unchecked((uint)0x0001),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_PLAYBACK_DEVICE_SOFT")]
    PlaybackDevicesoft = unchecked((uint)0x19D4),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_CAPTURE_DEVICE_SOFT")]
    CaptureDevicesoft = unchecked((uint)0x19D5),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_EVENT_TYPE_DEFAULT_DEVICE_CHANGED_SOFT")]
    EventTypeDefaultDeviceChangedsoft = unchecked((uint)0x19D6),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_EVENT_TYPE_DEVICE_ADDED_SOFT")]
    EventTypeDeviceAddedsoft = unchecked((uint)0x19D7),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_EVENT_TYPE_DEVICE_REMOVED_SOFT")]
    EventTypeDeviceRemovedsoft = unchecked((uint)0x19D8),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_EVENT_SUPPORTED_SOFT")]
    EventSupportedsoft = unchecked((uint)0x19D9),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("ALC_EVENT_NOT_SUPPORTED_SOFT")]
    EventNotSupportedsoft = unchecked((uint)0x19DA),
}
