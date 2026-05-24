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

[NativeName("AudioChannelLOKI")]
public enum AudioChannelLOKI : uint
{
    [NativeName("ALC_CHAN_MAIN_LOKI")]
    Main = 5242881,

    [NativeName("ALC_CHAN_PCM_LOKI")]
    Pcm = 5242882,

    [NativeName("ALC_CHAN_CD_LOKI")]
    Cd = 5242883,
}
