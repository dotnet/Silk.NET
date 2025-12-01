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

[NativeName("FilterFloat")]
public enum FilterFloat : uint
{
    [NativeName("AL_LOWPASS_GAIN")]
    LowpassGain = unchecked((uint)0x0001),

    [NativeName("AL_LOWPASS_GAINHF")]
    LowpassGainhf = unchecked((uint)0x0002),

    [NativeName("AL_HIGHPASS_GAIN")]
    HighpassGain = unchecked((uint)0x0001),

    [NativeName("AL_HIGHPASS_GAINLF")]
    HighpassGainlf = unchecked((uint)0x0002),

    [NativeName("AL_BANDPASS_GAIN")]
    BandpassGain = unchecked((uint)0x0001),

    [NativeName("AL_BANDPASS_GAINLF")]
    BandpassGainlf = unchecked((uint)0x0002),

    [NativeName("AL_BANDPASS_GAINHF")]
    BandpassGainhf = unchecked((uint)0x0003),
}
