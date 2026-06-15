// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneComponentsLocateInfoMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneComponentsLocateInfoMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public StructureType Type = StructureType.TypeSceneComponentsLocateInfoMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public void* Next;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SpaceHandle BaseSpace;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public long Time;

    [NativeName("componentIdCount")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public uint ComponentIdCount;

    [NativeName("componentIds")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public UuidMSFT* ComponentIds;

    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneComponentsLocateInfoMSFT() { }
}
