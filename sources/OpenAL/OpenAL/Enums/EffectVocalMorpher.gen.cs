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

[NativeName("EffectVocalMorpher")]
public enum EffectVocalMorpher : uint
{
    [NativeName("AL_VOCAL_MORPHER_PHONEMEA")]
    Phonemea = unchecked((uint)0x0001),

    [NativeName("AL_VOCAL_MORPHER_PHONEMEA_COARSE_TUNING")]
    PhonemeaCoarseTuning = unchecked((uint)0x0002),

    [NativeName("AL_VOCAL_MORPHER_PHONEMEB")]
    Phonemeb = unchecked((uint)0x0003),

    [NativeName("AL_VOCAL_MORPHER_PHONEMEB_COARSE_TUNING")]
    PhonemebCoarseTuning = unchecked((uint)0x0004),

    [NativeName("AL_VOCAL_MORPHER_WAVEFORM")]
    Waveform = unchecked((uint)0x0005),

    [NativeName("AL_VOCAL_MORPHER_RATE")]
    Rate = unchecked((uint)0x0006),
}
