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

[NativeName("EFXEAXREVERBPROPERTIES")]
public partial struct EfxEaxReverbProperties
{
    [NativeName("flDensity")]
    public float FlDensity;

    [NativeName("flDiffusion")]
    public float FlDiffusion;

    [NativeName("flGain")]
    public float FlGain;

    [NativeName("flGainHF")]
    public float FlGainHF;

    [NativeName("flGainLF")]
    public float FlGainLF;

    [NativeName("flDecayTime")]
    public float FlDecayTime;

    [NativeName("flDecayHFRatio")]
    public float FlDecayHFRatio;

    [NativeName("flDecayLFRatio")]
    public float FlDecayLFRatio;

    [NativeName("flReflectionsGain")]
    public float FlReflectionsGain;

    [NativeName("flReflectionsDelay")]
    public float FlReflectionsDelay;

    [NativeName("flReflectionsPan")]
    public EfxEaxReverbPropertiesFlReflectionsPan FlReflectionsPan;

    [NativeName("flLateReverbGain")]
    public float FlLateReverbGain;

    [NativeName("flLateReverbDelay")]
    public float FlLateReverbDelay;

    [NativeName("flLateReverbPan")]
    public EfxEaxReverbPropertiesFlLateReverbPan FlLateReverbPan;

    [NativeName("flEchoTime")]
    public float FlEchoTime;

    [NativeName("flEchoDepth")]
    public float FlEchoDepth;

    [NativeName("flModulationTime")]
    public float FlModulationTime;

    [NativeName("flModulationDepth")]
    public float FlModulationDepth;

    [NativeName("flAirAbsorptionGainHF")]
    public float FlAirAbsorptionGainHF;

    [NativeName("flHFReference")]
    public float FlHFReference;

    [NativeName("flLFReference")]
    public float FlLFReference;

    [NativeName("flRoomRolloffFactor")]
    public float FlRoomRolloffFactor;

    [NativeName("iDecayHFLimit")]
    public int IDecayHFLimit;
}
