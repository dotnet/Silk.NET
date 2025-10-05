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

[Transformed]
public enum EffectType : uint
{
    Null = unchecked((uint)0x0000),
    Reverb = unchecked((uint)0x0001),
    Chorus = unchecked((uint)0x0002),
    Distortion = unchecked((uint)0x0003),
    Echo = unchecked((uint)0x0004),
    Flanger = unchecked((uint)0x0005),
    FrequencyShifter = unchecked((uint)0x0006),
    VocalMorpher = unchecked((uint)0x0007),
    PitchShifter = unchecked((uint)0x0008),
    RingModulator = unchecked((uint)0x0009),
    Autowah = unchecked((uint)0x000A),
    Compressor = unchecked((uint)0x000B),
    Equalizer = unchecked((uint)0x000C),
    Eaxreverb = unchecked((uint)0x8000),
    DedicatedDialogue = unchecked((uint)0x9001),
    DedicatedLowFrequencyEffect = unchecked((uint)0x9000),
}
