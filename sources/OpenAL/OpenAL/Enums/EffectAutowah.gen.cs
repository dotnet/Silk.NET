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

[NativeName("EffectAutowah")]
public enum EffectAutowah : uint
{
    [NativeName("AL_AUTOWAH_ATTACK_TIME")]
    AttackTime = 1,

    [NativeName("AL_AUTOWAH_RELEASE_TIME")]
    ReleaseTime = 2,

    [NativeName("AL_AUTOWAH_RESONANCE")]
    Resonance = 3,

    [NativeName("AL_AUTOWAH_PEAK_GAIN")]
    PeakGain = 4,
}
