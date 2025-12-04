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

[NativeName("InternalFormatSOFT")]
public enum InternalFormatSOFT : uint
{
    [NativeName("AL_MONO8_SOFT")]
    Mono8 = unchecked((uint)0x1100),

    [NativeName("AL_MONO16_SOFT")]
    Mono16 = unchecked((uint)0x1101),

    [NativeName("AL_MONO32F_SOFT")]
    Mono32F = unchecked((uint)0x10010),

    [NativeName("AL_STEREO8_SOFT")]
    Stereo8 = unchecked((uint)0x1102),

    [NativeName("AL_STEREO16_SOFT")]
    Stereo16 = unchecked((uint)0x1103),

    [NativeName("AL_STEREO32F_SOFT")]
    Stereo32F = unchecked((uint)0x10011),

    [NativeName("AL_QUAD8_SOFT")]
    Quad8 = unchecked((uint)0x1204),

    [NativeName("AL_QUAD16_SOFT")]
    Quad16 = unchecked((uint)0x1205),

    [NativeName("AL_QUAD32F_SOFT")]
    Quad32F = unchecked((uint)0x1206),

    [NativeName("AL_REAR8_SOFT")]
    Rear8 = unchecked((uint)0x1207),

    [NativeName("AL_REAR16_SOFT")]
    Rear16 = unchecked((uint)0x1208),

    [NativeName("AL_REAR32F_SOFT")]
    Rear32F = unchecked((uint)0x1209),

    [NativeName("AL_5POINT1_8_SOFT")]
    X5Point1X8 = unchecked((uint)0x120A),

    [NativeName("AL_5POINT1_16_SOFT")]
    X5Point1X16 = unchecked((uint)0x120B),

    [NativeName("AL_5POINT1_32F_SOFT")]
    X5Point1X32F = unchecked((uint)0x120C),

    [NativeName("AL_6POINT1_8_SOFT")]
    X6Point1X8 = unchecked((uint)0x120D),

    [NativeName("AL_6POINT1_16_SOFT")]
    X6Point1X16 = unchecked((uint)0x120E),

    [NativeName("AL_6POINT1_32F_SOFT")]
    X6Point1X32F = unchecked((uint)0x120F),

    [NativeName("AL_7POINT1_8_SOFT")]
    X7Point1X8 = unchecked((uint)0x1210),

    [NativeName("AL_7POINT1_16_SOFT")]
    X7Point1X16 = unchecked((uint)0x1211),

    [NativeName("AL_7POINT1_32F_SOFT")]
    X7Point1X32F = unchecked((uint)0x1212),
}
