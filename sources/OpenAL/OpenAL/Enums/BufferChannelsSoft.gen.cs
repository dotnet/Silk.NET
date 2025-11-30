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

[NameAffix("Suffix", "SOFT", 0)]
[NativeName("BufferChannelsSOFT")]
[Transformed]
public enum BufferChannelsSoft : uint
{
    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_MONO_SOFT")]
    Monosoft = unchecked((uint)0x1500),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_STEREO_SOFT")]
    Stereosoft = unchecked((uint)0x1501),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_REAR_SOFT")]
    Rearsoft = unchecked((uint)0x1502),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_QUAD_SOFT")]
    Quadsoft = unchecked((uint)0x1503),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_5POINT1_SOFT")]
    X5Point1Soft = unchecked((uint)0x1504),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_6POINT1_SOFT")]
    X6Point1Soft = unchecked((uint)0x1505),

    [NameAffix("Suffix", "SOFT", 0)]
    [NativeName("AL_7POINT1_SOFT")]
    X7Point1Soft = unchecked((uint)0x1506),
}
