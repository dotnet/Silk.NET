// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrNewSceneComputeInfoMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct NewSceneComputeInfoMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public StructureType Type = StructureType.NewSceneComputeInfoMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public void* Next;

    [NativeName("requestedFeatureCount")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public uint RequestedFeatureCount;

    [NativeName("requestedFeatures")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneComputeFeatureMSFT* RequestedFeatures;

    [NativeName("consistency")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneComputeConsistencyMSFT Consistency;

    [NativeName("bounds")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneBoundsMSFT Bounds;

    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public NewSceneComputeInfoMSFT() { }
}
