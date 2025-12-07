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
public enum EffectEAXReverb : uint
{
    Density = unchecked((uint)0x0001),
    Diffusion = unchecked((uint)0x0002),
    Gain = unchecked((uint)0x0003),
    Gainhf = unchecked((uint)0x0004),
    Gainlf = unchecked((uint)0x0005),
    DecayTime = unchecked((uint)0x0006),
    DecayHfratio = unchecked((uint)0x0007),
    DecayLfratio = unchecked((uint)0x0008),
    ReflectionsGain = unchecked((uint)0x0009),
    ReflectionsDelay = unchecked((uint)0x000A),
    ReflectionsPan = unchecked((uint)0x000B),
    LateReverbGain = unchecked((uint)0x000C),
    LateReverbDelay = unchecked((uint)0x000D),
    LateReverbPan = unchecked((uint)0x000E),
    EchoTime = unchecked((uint)0x000F),
    EchoDepth = unchecked((uint)0x0010),
    ModulationTime = unchecked((uint)0x0011),
    ModulationDepth = unchecked((uint)0x0012),
    AirAbsorptionGainhf = unchecked((uint)0x0013),
    Hfreference = unchecked((uint)0x0014),
    Lfreference = unchecked((uint)0x0015),
    RoomRolloffFactor = unchecked((uint)0x0016),
    DecayHflimit = unchecked((uint)0x0017),
}
