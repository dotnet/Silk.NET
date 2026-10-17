// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrDirectionalLightANDROID")]
public unsafe partial struct DirectionalLightANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.DirectionalLightANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("state")]
    public LightEstimateStateANDROID State;

    [NativeName("intensity")]
    public Vector3F Intensity;

    [NativeName("direction")]
    public Vector3F Direction;

    public DirectionalLightANDROID() { }
}
