// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughLayerMeshANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PassthroughLayerMeshANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public StructureType Type = StructureType.PassthroughLayerMeshANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public void* Next;

    [NativeName("windingOrder")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public WindingOrderANDROID WindingOrder;

    [NativeName("vertexCount")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public uint VertexCount;

    [NativeName("vertices")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public Vector3F* Vertices;

    [NativeName("indexCount")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public uint IndexCount;

    [NativeName("indices")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public ushort* Indices;

    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    public PassthroughLayerMeshANDROID() { }
}
