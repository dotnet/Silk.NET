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

[NativeName("EffectRingModulator")]
[Transformed]
public enum EffectRingModulator : uint
{
    [NativeName("AL_RING_MODULATOR_FREQUENCY")]
    Frequency = unchecked((uint)0x0001),

    [NativeName("AL_RING_MODULATOR_HIGHPASS_CUTOFF")]
    HighpassCutoff = unchecked((uint)0x0002),

    [NativeName("AL_RING_MODULATOR_WAVEFORM")]
    Waveform = unchecked((uint)0x0003),
}
