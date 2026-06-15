// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneComponentLocationsMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneComponentLocationsMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public StructureType Type = StructureType.TypeSceneComponentLocationsMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public void* Next;

    [NativeName("locationCount")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public uint LocationCount;

    [NativeName("locations")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneComponentLocationMSFT* Locations;

    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneComponentLocationsMSFT() { }
}
