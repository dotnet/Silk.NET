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

[NativeName("RenderFormatChannelSOFT")]
public enum RenderFormatChannelSOFT : uint
{
    [NativeName("ALC_MONO_SOFT")]
    Mono = 5376,

    [NativeName("ALC_STEREO_SOFT")]
    Stereo = 5377,

    [NativeName("ALC_QUAD_SOFT")]
    Quad = 5379,

    [NativeName("ALC_5POINT1_SOFT")]
    X5Point1 = 5380,

    [NativeName("ALC_6POINT1_SOFT")]
    X6Point1 = 5381,

    [NativeName("ALC_7POINT1_SOFT")]
    X7Point1 = 5382,

    [NativeName("ALC_BFORMAT3D_SOFT")]
    Bformat3D = 5383,
}
