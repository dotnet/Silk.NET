// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrScenePlanesMSFT")]
public unsafe partial struct ScenePlanesMSFT
{
    [NativeName("type")]
    public StructureType Type = StructureType.ScenePlanesMSFT;

    [NativeName("next")]
    public void* Next;

    [NativeName("scenePlaneCount")]
    public uint ScenePlaneCount;

    [NativeName("scenePlanes")]
    public ScenePlaneMSFT* ScenePlanes;

    public ScenePlanesMSFT() { }
}
