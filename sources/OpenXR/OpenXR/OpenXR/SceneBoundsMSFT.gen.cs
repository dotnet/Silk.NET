// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneBoundsMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneBoundsMSFT
{
    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SpaceHandle Space;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public long Time;

    [NativeName("sphereCount")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public uint SphereCount;

    [NativeName("spheres")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneSphereBoundMSFT* Spheres;

    [NativeName("boxCount")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public uint BoxCount;

    [NativeName("boxes")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneOrientedBoxBoundMSFT* Boxes;

    [NativeName("frustumCount")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public uint FrustumCount;

    [NativeName("frustums")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneFrustumBoundMSFT* Frustums;
}
