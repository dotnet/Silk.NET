// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneBoundsMSFT")]
public unsafe partial struct SceneBoundsMSFT
{
    [NativeName("space")]
    public SpaceHandle Space;

    [NativeName("time")]
    public long Time;

    [NativeName("sphereCount")]
    public uint SphereCount;

    [NativeName("spheres")]
    public SceneSphereBoundMSFT* Spheres;

    [NativeName("boxCount")]
    public uint BoxCount;

    [NativeName("boxes")]
    public SceneOrientedBoxBoundMSFT* Boxes;

    [NativeName("frustumCount")]
    public uint FrustumCount;

    [NativeName("frustums")]
    public SceneFrustumBoundMSFT* Frustums;
}
