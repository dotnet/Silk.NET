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

[NativeName("BufferChannelsSOFT")]
public enum BufferChannelsSOFT : uint
{
    [NativeName("AL_MONO_SOFT")]
    Mono = 5376,

    [NativeName("AL_STEREO_SOFT")]
    Stereo = 5377,

    [NativeName("AL_REAR_SOFT")]
    Rear = 5378,

    [NativeName("AL_QUAD_SOFT")]
    Quad = 5379,

    [NativeName("AL_5POINT1_SOFT")]
    X5Point1 = 5380,

    [NativeName("AL_6POINT1_SOFT")]
    X6Point1 = 5381,

    [NativeName("AL_7POINT1_SOFT")]
    X7Point1 = 5382,
}
