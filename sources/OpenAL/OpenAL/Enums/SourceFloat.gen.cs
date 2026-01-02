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
public enum SourceFloat : uint
{
    ConeInnerAngle = unchecked((uint)0x1001),
    ConeOuterAngle = unchecked((uint)0x1002),
    Pitch = unchecked((uint)0x1003),
    Gain = unchecked((uint)0x100A),
    MinGain = unchecked((uint)0x100D),
    MaxGain = unchecked((uint)0x100E),
    ReferenceDistance = unchecked((uint)0x1020),
    RolloffFactor = unchecked((uint)0x1021),
    MaxDistance = unchecked((uint)0x1023),
    SecOffset = unchecked((uint)0x1024),
    SampleOffset = unchecked((uint)0x1025),
    ByteOffset = unchecked((uint)0x1026),
    ConeOuterGainhf = unchecked((uint)0x20009),
    ByteRwOffsetsSOFT = unchecked((uint)0x1031),
    SampleRwOffsetsSOFT = unchecked((uint)0x1032),
    StereoAngles = unchecked((uint)0x1030),
    SourceRadius = unchecked((uint)0x1031),
    SecOffsetLatencySOFT = unchecked((uint)0x1201),
    SuperStereoWidthSOFT = unchecked((uint)0x19B1),
}
