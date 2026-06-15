// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneComponentsMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneComponentsMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public StructureType Type = StructureType.TypeSceneComponentsMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public void* Next;

    [NativeName("componentCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public uint ComponentCapacityInput;

    [NativeName("componentCountOutput")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public uint ComponentCountOutput;

    [NativeName("components")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneComponentMSFT* Components;

    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneComponentsMSFT() { }
}
