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

    [NativeName("ALC_INVALID_CONTEXT")]
    InvalidContEXT = unchecked((uint)0xA002),

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

    [NativeName("ALC_CHAN_MAIN_LOKI")]
    ChanMainLOKI = unchecked((uint)0x500001),

    [NativeName("ALC_CHAN_PCM_LOKI")]
    ChanPcmLOKI = unchecked((uint)0x500002),

    [NativeName("ALC_CHAN_CD_LOKI")]
    ChanCdLOKI = unchecked((uint)0x500003),

    [NativeName("ALC_EFX_MAJOR_VERSION")]
    EfxMajorVersion = unchecked((uint)0x20001),

    [NativeName("ALC_EFX_MINOR_VERSION")]
    EfxMinorVersion = unchecked((uint)0x20002),

    [NativeName("ALC_MAX_AUXILIARY_SENDS")]
    MaxAuxiliarySends = unchecked((uint)0x20003),

    [NativeName("ALC_CONNECTED")]
    Connected = unchecked((uint)0x313),

    [NativeName("ALC_FORMAT_CHANNELS_SOFT")]
    FormatChannelsSOFT = unchecked((uint)0x1990),

    [NativeName("ALC_FORMAT_TYPE_SOFT")]
    FormatTypeSOFT = unchecked((uint)0x1991),

    [NativeName("ALC_BYTE_SOFT")]
    ByteSOFT = unchecked((uint)0x1400),

    [NativeName("ALC_UNSIGNED_BYTE_SOFT")]
    UnsignedByteSOFT = unchecked((uint)0x1401),

    [NativeName("ALC_SHORT_SOFT")]
    ShortSOFT = unchecked((uint)0x1402),

    [NativeName("ALC_UNSIGNED_SHORT_SOFT")]
    UnsignedShortSOFT = unchecked((uint)0x1403),

    [NativeName("ALC_INT_SOFT")]
    IntSOFT = unchecked((uint)0x1404),

    [NativeName("ALC_UNSIGNED_INT_SOFT")]
    UnsignedIntSOFT = unchecked((uint)0x1405),

    [NativeName("ALC_FLOAT_SOFT")]
    FloatSOFT = unchecked((uint)0x1406),

    [NativeName("ALC_MONO_SOFT")]
    MonoSOFT = unchecked((uint)0x1500),

    [NativeName("ALC_STEREO_SOFT")]
    StereoSOFT = unchecked((uint)0x1501),

    [NativeName("ALC_QUAD_SOFT")]
    QuadSOFT = unchecked((uint)0x1503),

    [NativeName("ALC_5POINT1_SOFT")]
    X5Point1SOFT = unchecked((uint)0x1504),

    [NativeName("ALC_6POINT1_SOFT")]
    X6Point1SOFT = unchecked((uint)0x1505),

    [NativeName("ALC_7POINT1_SOFT")]
    X7Point1SOFT = unchecked((uint)0x1506),

    [NativeName("ALC_HRTF_SOFT")]
    HrtfSOFT = unchecked((uint)0x1992),

    [NativeName("ALC_DONT_CARE_SOFT")]
    DontCareSOFT = unchecked((uint)0x0002),

    [NativeName("ALC_HRTF_STATUS_SOFT")]
    HrtfStatusSOFT = unchecked((uint)0x1993),

    [NativeName("ALC_HRTF_DISABLED_SOFT")]
    HrtfDisabledSOFT = unchecked((uint)0x0000),

    [NativeName("ALC_HRTF_ENABLED_SOFT")]
    HrtfEnabledSOFT = unchecked((uint)0x0001),

    [NativeName("ALC_HRTF_DENIED_SOFT")]
    HrtfDeniedSOFT = unchecked((uint)0x0002),

    [NativeName("ALC_HRTF_REQUIRED_SOFT")]
    HrtfRequiredSOFT = unchecked((uint)0x0003),

    [NativeName("ALC_HRTF_HEADPHONES_DETECTED_SOFT")]
    HrtfHeadphonesDetectedSOFT = unchecked((uint)0x0004),

    [NativeName("ALC_HRTF_UNSUPPORTED_FORMAT_SOFT")]
    HrtfUnsupportedFormatSOFT = unchecked((uint)0x0005),

    [NativeName("ALC_NUM_HRTF_SPECIFIERS_SOFT")]
    NumHrtfSpecifiersSOFT = unchecked((uint)0x1994),

    [NativeName("ALC_HRTF_SPECIFIER_SOFT")]
    HrtfSpecifierSOFT = unchecked((uint)0x1995),

    [NativeName("ALC_HRTF_ID_SOFT")]
    HrtfIdSOFT = unchecked((uint)0x1996),

    [NativeName("ALC_OUTPUT_LIMITER_SOFT")]
    OutputLimiterSOFT = unchecked((uint)0x199A),

    [NativeName("ALC_DEVICE_CLOCK_SOFT")]
    DeviceClockSOFT = unchecked((uint)0x1600),

    [NativeName("ALC_DEVICE_LATENCY_SOFT")]
    DeviceLatencySOFT = unchecked((uint)0x1601),

    [NativeName("ALC_DEVICE_CLOCK_LATENCY_SOFT")]
    DeviceClockLatencySOFT = unchecked((uint)0x1602),

    [NativeName("ALC_AMBISONIC_LAYOUT_SOFT")]
    AmbisonicLayoutSOFT = unchecked((uint)0x1997),

    [NativeName("ALC_AMBISONIC_SCALING_SOFT")]
    AmbisonicScalingSOFT = unchecked((uint)0x1998),

    [NativeName("ALC_AMBISONIC_ORDER_SOFT")]
    AmbisonicOrderSOFT = unchecked((uint)0x1999),

    [NativeName("ALC_MAX_AMBISONIC_ORDER_SOFT")]
    MaxAmbisonicOrderSOFT = unchecked((uint)0x199B),

    [NativeName("ALC_BFORMAT3D_SOFT")]
    Bformat3DSOFT = unchecked((uint)0x1507),

    [NativeName("ALC_FUMA_SOFT")]
    FumaSOFT = unchecked((uint)0x0000),

    [NativeName("ALC_ACN_SOFT")]
    AcnSOFT = unchecked((uint)0x0001),

    [NativeName("ALC_SN3D_SOFT")]
    Sn3DSOFT = unchecked((uint)0x0001),

    [NativeName("ALC_N3D_SOFT")]
    N3DSOFT = unchecked((uint)0x0002),

    [NativeName("ALC_OUTPUT_MODE_SOFT")]
    OutputModeSOFT = unchecked((uint)0x19AC),

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

    [NativeName("ALC_CONTEXT_FLAGS_EXT")]
    ContextFlagsEXT = unchecked((uint)0x19CF),

    [NativeName("ALC_CONTEXT_DEBUG_BIT_EXT")]
    ContextDebugBitEXT = unchecked((uint)0x0001),

    [NativeName("ALC_PLAYBACK_DEVICE_SOFT")]
    PlaybackDeviceSOFT = unchecked((uint)0x19D4),

    [NativeName("ALC_CAPTURE_DEVICE_SOFT")]
    CaptureDeviceSOFT = unchecked((uint)0x19D5),

    [NativeName("ALC_EVENT_TYPE_DEFAULT_DEVICE_CHANGED_SOFT")]
    EventTypeDefaultDeviceChangedSOFT = unchecked((uint)0x19D6),

    [NativeName("ALC_EVENT_TYPE_DEVICE_ADDED_SOFT")]
    EventTypeDeviceAddedSOFT = unchecked((uint)0x19D7),

    [NativeName("ALC_EVENT_TYPE_DEVICE_REMOVED_SOFT")]
    EventTypeDeviceRemovedSOFT = unchecked((uint)0x19D8),

    [NativeName("ALC_EVENT_SUPPORTED_SOFT")]
    EventSupportedSOFT = unchecked((uint)0x19D9),

    [NativeName("ALC_EVENT_NOT_SUPPORTED_SOFT")]
    EventNotSupportedSOFT = unchecked((uint)0x19DA),
}
