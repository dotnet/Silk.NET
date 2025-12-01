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

[NativeName("ListenerPName")]
public enum ListenerPName : uint
{
    [NativeName("AL_POSITION")]
    Position = unchecked((uint)0x1004),

    [NativeName("AL_DIRECTION")]
    Direction = unchecked((uint)0x1005),

    [NativeName("AL_VELOCITY")]
    Velocity = unchecked((uint)0x1006),

    [NativeName("AL_ORIENTATION")]
    Orientation = unchecked((uint)0x100F),

    [NativeName("AL_CONE_OUTER_GAIN")]
    ConeOuterGain = unchecked((uint)0x1022),

    [NativeName("AL_METERS_PER_UNIT")]
    MetersPerUnit = unchecked((uint)0x20004),
}
