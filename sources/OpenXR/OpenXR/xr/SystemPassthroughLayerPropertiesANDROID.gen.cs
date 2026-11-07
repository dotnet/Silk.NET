// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemPassthroughLayerPropertiesANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemPassthroughLayerPropertiesANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public StructureType Type = StructureType.SystemPassthroughLayerPropertiesANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public void* Next;

    [NativeName("supportsPassthroughLayer")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public MaybeBool<uint> SupportsPassthroughLayer;

    [NativeName("maxMeshIndexCount")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public uint MaxMeshIndexCount;

    [NativeName("maxMeshVertexCount")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public uint MaxMeshVertexCount;

    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public SystemPassthroughLayerPropertiesANDROID() { }
}
