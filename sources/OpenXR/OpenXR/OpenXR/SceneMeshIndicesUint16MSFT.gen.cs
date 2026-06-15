// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneMeshIndicesUint16MSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneMeshIndicesUint16MSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public StructureType Type = StructureType.TypeSceneMeshIndicesUint16MSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public void* Next;

    [NativeName("indexCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public uint IndexCapacityInput;

    [NativeName("indexCountOutput")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public uint IndexCountOutput;

    [NativeName("indices")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public ushort* Indices;

    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneMeshIndicesUint16MSFT() { }
}
