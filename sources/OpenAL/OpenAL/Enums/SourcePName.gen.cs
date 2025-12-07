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
public enum SourcePName : uint
{
    SourceRelative = unchecked((uint)0x202),
    ConeInnerAngle = unchecked((uint)0x1001),
    ConeOuterAngle = unchecked((uint)0x1002),
    Pitch = unchecked((uint)0x1003),
    Position = unchecked((uint)0x1004),
    Direction = unchecked((uint)0x1005),
    Velocity = unchecked((uint)0x1006),
    Looping = unchecked((uint)0x1007),
    Buffer = unchecked((uint)0x1009),
    Gain = unchecked((uint)0x100A),
    MinGain = unchecked((uint)0x100D),
    MaxGain = unchecked((uint)0x100E),
    SourceState = unchecked((uint)0x1010),
    BuffersQueued = unchecked((uint)0x1015),
    BuffersProcessed = unchecked((uint)0x1016),
    ReferenceDistance = unchecked((uint)0x1020),
    RolloffFactor = unchecked((uint)0x1021),
    MaxDistance = unchecked((uint)0x1023),
    SecOffset = unchecked((uint)0x1024),
    SampleOffset = unchecked((uint)0x1025),
    ByteOffset = unchecked((uint)0x1026),
    SourceType = unchecked((uint)0x1027),
    DirectFilter = unchecked((uint)0x20005),
    AuxiliarySendFilter = unchecked((uint)0x20006),
    AirAbsorptionFactor = unchecked((uint)0x20007),
    RoomRolloffFactor = unchecked((uint)0x20008),
    ConeOuterGainhf = unchecked((uint)0x20009),
    DirectFilterGainhfAuto = unchecked((uint)0x2000A),
    AuxiliarySendFilterGainAuto = unchecked((uint)0x2000B),
    AuxiliarySendFilterGainhfAuto = unchecked((uint)0x2000C),
    ByteRwOffsetsSOFT = unchecked((uint)0x1031),
    SampleRwOffsetsSOFT = unchecked((uint)0x1032),
    DirectChannelsSOFT = unchecked((uint)0x1033),
    StereoAngles = unchecked((uint)0x1030),
    SourceRadius = unchecked((uint)0x1031),
    SampleOffsetLatencySOFT = unchecked((uint)0x1200),
    SecOffsetLatencySOFT = unchecked((uint)0x1201),
    SourceResamplerSOFT = unchecked((uint)0x1212),
    SourceSpatializeSOFT = unchecked((uint)0x1214),
    SampleOffsetClockSOFT = unchecked((uint)0x1202),
    SecOffsetClockSOFT = unchecked((uint)0x1203),
    StereoModeSOFT = unchecked((uint)0x19B0),
    SuperStereoWidthSOFT = unchecked((uint)0x19B1),
}
