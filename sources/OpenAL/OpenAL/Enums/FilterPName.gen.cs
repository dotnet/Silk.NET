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

[NativeName("FilterPName")]
public enum FilterPName : uint
{
    [NativeName("AL_LOWPASS_GAIN")]
    LowpassGain = 1,

    [NativeName("AL_LOWPASS_GAINHF")]
    LowpassGainhf = 2,

    [NativeName("AL_HIGHPASS_GAIN")]
    HighpassGain = 1,

    [NativeName("AL_HIGHPASS_GAINLF")]
    HighpassGainlf = 2,

    [NativeName("AL_BANDPASS_GAIN")]
    BandpassGain = 1,

    [NativeName("AL_BANDPASS_GAINLF")]
    BandpassGainlf = 2,

    [NativeName("AL_BANDPASS_GAINHF")]
    BandpassGainhf = 3,

    [NativeName("AL_FILTER_TYPE")]
    FilterType = 32769,
}
