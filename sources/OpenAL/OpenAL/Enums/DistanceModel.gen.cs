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

[NativeName("DistanceModel")]
public enum DistanceModel : uint
{
    [NativeName("AL_NONE")]
    None = 0,

    [NativeName("AL_INVERSE_DISTANCE")]
    InverseDistance = 53249,

    [NativeName("AL_INVERSE_DISTANCE_CLAMPED")]
    InverseDistanceClamped = 53250,

    [NativeName("AL_LINEAR_DISTANCE")]
    LinearDistance = 53251,

    [NativeName("AL_LINEAR_DISTANCE_CLAMPED")]
    LinearDistanceClamped = 53252,

    [NativeName("AL_EXPONENT_DISTANCE")]
    ExponentDistance = 53253,

    [NativeName("AL_EXPONENT_DISTANCE_CLAMPED")]
    ExponentDistanceClamped = 53254,
}
