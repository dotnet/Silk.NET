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
public enum EffectEqualizer : uint
{
    LowGain = unchecked((uint)0x0001),
    LowCutoff = unchecked((uint)0x0002),
    Mid1Gain = unchecked((uint)0x0003),
    Mid1Center = unchecked((uint)0x0004),
    Mid1Width = unchecked((uint)0x0005),
    Mid2Gain = unchecked((uint)0x0006),
    Mid2Center = unchecked((uint)0x0007),
    Mid2Width = unchecked((uint)0x0008),
    HighGain = unchecked((uint)0x0009),
    HighCutoff = unchecked((uint)0x000A),
}
