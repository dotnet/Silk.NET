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

[NativeName("EffectFlanger")]
public enum EffectFlanger : uint
{
    [NativeName("AL_FLANGER_WAVEFORM")]
    Waveform = 1,

    [NativeName("AL_FLANGER_PHASE")]
    Phase = 2,

    [NativeName("AL_FLANGER_RATE")]
    Rate = 3,

    [NativeName("AL_FLANGER_DEPTH")]
    Depth = 4,

    [NativeName("AL_FLANGER_FEEDBACK")]
    Feedback = 5,

    [NativeName("AL_FLANGER_DELAY")]
    Delay = 6,
}
