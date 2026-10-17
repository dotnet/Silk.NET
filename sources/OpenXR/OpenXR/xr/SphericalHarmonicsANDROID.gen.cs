// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSphericalHarmonicsANDROID")]
public unsafe partial struct SphericalHarmonicsANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.SphericalHarmonicsANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("state")]
    public LightEstimateStateANDROID State;

    [NativeName("kind")]
    public SphericalHarmonicsKindANDROID Kind;

    [NativeName("coefficients")]
    public SphericalHarmonicsANDROIDCoefficients Coefficients;

    public SphericalHarmonicsANDROID() { }
}
