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

public partial struct EfxEaxReverbProperties
{
    public float FlDensity;
    public float FlDiffusion;
    public float FlGain;
    public float FlGainHf;
    public float FlGainLf;
    public float FlDecayTime;
    public float FlDecayHfRatio;
    public float FlDecayLfRatio;
    public float FlReflectionsGain;
    public float FlReflectionsDelay;

    [NativeTypeName("float[3]")]
    public EfxEaxReverbPropertiesFlReflectionsPan FlReflectionsPan;
    public float FlLateReverbGain;
    public float FlLateReverbDelay;

    [NativeTypeName("float[3]")]
    public EfxEaxReverbPropertiesFlLateReverbPan FlLateReverbPan;
    public float FlEchoTime;
    public float FlEchoDepth;
    public float FlModulationTime;
    public float FlModulationDepth;
    public float FlAirAbsorptionGainHf;
    public float FlHfReference;
    public float FlLfReference;
    public float FlRoomRolloffFactor;
    public int IDecayHfLimit;
}
