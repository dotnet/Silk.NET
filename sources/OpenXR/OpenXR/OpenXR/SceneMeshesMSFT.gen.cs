// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneMeshesMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneMeshesMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public StructureType Type = StructureType.TypeSceneMeshesMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public void* Next;

    [NativeName("sceneMeshCount")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public uint SceneMeshCount;

    [NativeName("sceneMeshes")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneMeshMSFT* SceneMeshes;

    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneMeshesMSFT() { }
}
