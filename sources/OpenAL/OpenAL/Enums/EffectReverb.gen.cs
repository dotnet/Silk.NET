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
public enum EffectReverb : uint
{
    Density = unchecked((uint)0x0001),
    Diffusion = unchecked((uint)0x0002),
    Gain = unchecked((uint)0x0003),
    Gainhf = unchecked((uint)0x0004),
    DecayTime = unchecked((uint)0x0005),
    DecayHfratio = unchecked((uint)0x0006),
    ReflectionsGain = unchecked((uint)0x0007),
    ReflectionsDelay = unchecked((uint)0x0008),
    LateReverbGain = unchecked((uint)0x0009),
    LateReverbDelay = unchecked((uint)0x000A),
    AirAbsorptionGainhf = unchecked((uint)0x000B),
    RoomRolloffFactor = unchecked((uint)0x000C),
    DecayHflimit = unchecked((uint)0x000D),
}
