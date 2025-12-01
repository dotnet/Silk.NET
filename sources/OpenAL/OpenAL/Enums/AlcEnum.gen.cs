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
    Invalid = 0,

    [NativeName("ALC_FALSE")]
    False = 0,

    [NativeName("ALC_TRUE")]
    True = 1,

    [NativeName("ALC_FREQUENCY")]
    Frequency = 4103,

    [NativeName("ALC_REFRESH")]
    Refresh = 4104,

    [NativeName("ALC_SYNC")]
    Sync = 4105,

    [NativeName("ALC_NO_ERROR")]
    NoError = 0,

    [NativeName("ALC_INVALID_DEVICE")]
    InvalidDevice = 40961,

    [NativeName("ALC_INVALID_CONTEXT")]
    InvalidContEXT = 40962,

    [NativeName("ALC_INVALID_ENUM")]
    InvalidEnum = 40963,

    [NativeName("ALC_INVALID_VALUE")]
    InvalidValue = 40964,

    [NativeName("ALC_OUT_OF_MEMORY")]
    OutOfMemory = 40965,

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

    [NativeName("ALC_CHAN_MAIN_LOKI")]
    ChanMainLOKI = 5242881,

    [NativeName("ALC_CHAN_PCM_LOKI")]
    ChanPcmLOKI = 5242882,

    [NativeName("ALC_CHAN_CD_LOKI")]
    ChanCdLOKI = 5242883,

    [NativeName("ALC_EFX_MAJOR_VERSION")]
    EfxMajorVersion = 131073,

    [NativeName("ALC_EFX_MINOR_VERSION")]
    EfxMinorVersion = 131074,

    [NativeName("ALC_MAX_AUXILIARY_SENDS")]
    MaxAuxiliarySends = 131075,

    [NativeName("ALC_CONNECTED")]
    Connected = 787,

    [NativeName("ALC_FORMAT_CHANNELS_SOFT")]
    FormatChannelsSOFT = 6544,

    [NativeName("ALC_FORMAT_TYPE_SOFT")]
    FormatTypeSOFT = 6545,

    [NativeName("ALC_BYTE_SOFT")]
    ByteSOFT = 5120,

    [NativeName("ALC_UNSIGNED_BYTE_SOFT")]
    UnsignedByteSOFT = 5121,

    [NativeName("ALC_SHORT_SOFT")]
    ShortSOFT = 5122,

    [NativeName("ALC_UNSIGNED_SHORT_SOFT")]
    UnsignedShortSOFT = 5123,

    [NativeName("ALC_INT_SOFT")]
    IntSOFT = 5124,

    [NativeName("ALC_UNSIGNED_INT_SOFT")]
    UnsignedIntSOFT = 5125,

    [NativeName("ALC_FLOAT_SOFT")]
    FloatSOFT = 5126,

    [NativeName("ALC_MONO_SOFT")]
    MonoSOFT = 5376,

    [NativeName("ALC_STEREO_SOFT")]
    StereoSOFT = 5377,

    [NativeName("ALC_QUAD_SOFT")]
    QuadSOFT = 5379,

    [NativeName("ALC_5POINT1_SOFT")]
    X5Point1SOFT = 5380,

    [NativeName("ALC_6POINT1_SOFT")]
    X6Point1SOFT = 5381,

    [NativeName("ALC_7POINT1_SOFT")]
    X7Point1SOFT = 5382,

    [NativeName("ALC_HRTF_SOFT")]
    HrtfSOFT = 6546,

    [NativeName("ALC_DONT_CARE_SOFT")]
    DontCareSOFT = 2,

    [NativeName("ALC_HRTF_STATUS_SOFT")]
    HrtfStatusSOFT = 6547,

    [NativeName("ALC_HRTF_DISABLED_SOFT")]
    HrtfDisabledSOFT = 0,

    [NativeName("ALC_HRTF_ENABLED_SOFT")]
    HrtfEnabledSOFT = 1,

    [NativeName("ALC_HRTF_DENIED_SOFT")]
    HrtfDeniedSOFT = 2,

    [NativeName("ALC_HRTF_REQUIRED_SOFT")]
    HrtfRequiredSOFT = 3,

    [NativeName("ALC_HRTF_HEADPHONES_DETECTED_SOFT")]
    HrtfHeadphonesDetectedSOFT = 4,

    [NativeName("ALC_HRTF_UNSUPPORTED_FORMAT_SOFT")]
    HrtfUnsupportedFormatSOFT = 5,

    [NativeName("ALC_NUM_HRTF_SPECIFIERS_SOFT")]
    NumHrtfSpecifiersSOFT = 6548,

    [NativeName("ALC_HRTF_SPECIFIER_SOFT")]
    HrtfSpecifierSOFT = 6549,

    [NativeName("ALC_HRTF_ID_SOFT")]
    HrtfIdSOFT = 6550,

    [NativeName("ALC_OUTPUT_LIMITER_SOFT")]
    OutputLimiterSOFT = 6554,

    [NativeName("ALC_DEVICE_CLOCK_SOFT")]
    DeviceClockSOFT = 5632,

    [NativeName("ALC_DEVICE_LATENCY_SOFT")]
    DeviceLatencySOFT = 5633,

    [NativeName("ALC_DEVICE_CLOCK_LATENCY_SOFT")]
    DeviceClockLatencySOFT = 5634,

    [NativeName("ALC_AMBISONIC_LAYOUT_SOFT")]
    AmbisonicLayoutSOFT = 6551,

    [NativeName("ALC_AMBISONIC_SCALING_SOFT")]
    AmbisonicScalingSOFT = 6552,

    [NativeName("ALC_AMBISONIC_ORDER_SOFT")]
    AmbisonicOrderSOFT = 6553,

    [NativeName("ALC_MAX_AMBISONIC_ORDER_SOFT")]
    MaxAmbisonicOrderSOFT = 6555,

    [NativeName("ALC_BFORMAT3D_SOFT")]
    Bformat3DSOFT = 5383,

    [NativeName("ALC_FUMA_SOFT")]
    FumaSOFT = 0,

    [NativeName("ALC_ACN_SOFT")]
    AcnSOFT = 1,

    [NativeName("ALC_SN3D_SOFT")]
    Sn3DSOFT = 1,

    [NativeName("ALC_N3D_SOFT")]
    N3DSOFT = 2,

    [NativeName("ALC_OUTPUT_MODE_SOFT")]
    OutputModeSOFT = 6572,

    [NativeName("ALC_ANY_SOFT")]
    AnySOFT = 6573,

    [NativeName("ALC_STEREO_BASIC_SOFT")]
    StereoBasicSOFT = 6574,

    [NativeName("ALC_STEREO_UHJ_SOFT")]
    StereoUhjSOFT = 6575,

    [NativeName("ALC_STEREO_HRTF_SOFT")]
    StereoHrtfSOFT = 6578,

    [NativeName("ALC_SURROUND_5_1_SOFT")]
    Surround5X1SOFT = 5380,

    [NativeName("ALC_SURROUND_6_1_SOFT")]
    Surround6X1SOFT = 5381,

    [NativeName("ALC_SURROUND_7_1_SOFT")]
    Surround7X1SOFT = 5382,

    [NativeName("ALC_CONTEXT_FLAGS_EXT")]
    ContextFlagsEXT = 6607,

    [NativeName("ALC_CONTEXT_DEBUG_BIT_EXT")]
    ContextDebugBitEXT = 1,

    [NativeName("ALC_PLAYBACK_DEVICE_SOFT")]
    PlaybackDeviceSOFT = 6612,

    [NativeName("ALC_CAPTURE_DEVICE_SOFT")]
    CaptureDeviceSOFT = 6613,

    [NativeName("ALC_EVENT_TYPE_DEFAULT_DEVICE_CHANGED_SOFT")]
    EventTypeDefaultDeviceChangedSOFT = 6614,

    [NativeName("ALC_EVENT_TYPE_DEVICE_ADDED_SOFT")]
    EventTypeDeviceAddedSOFT = 6615,

    [NativeName("ALC_EVENT_TYPE_DEVICE_REMOVED_SOFT")]
    EventTypeDeviceRemovedSOFT = 6616,

    [NativeName("ALC_EVENT_SUPPORTED_SOFT")]
    EventSupportedSOFT = 6617,

    [NativeName("ALC_EVENT_NOT_SUPPORTED_SOFT")]
    EventNotSupportedSOFT = 6618,
}
