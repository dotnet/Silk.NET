// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneSubmeshDataANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneSubmeshDataANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public StructureType Type = StructureType.TypeSceneSubmeshDataANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public void* Next;

    [NativeName("submeshId")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public Uuid SubmeshId;

    [NativeName("vertexCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public uint VertexCapacityInput;

    [NativeName("vertexCountOutput")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public uint VertexCountOutput;

    [NativeName("vertexPositions")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public Vector3F* VertexPositions;

    [NativeName("vertexNormals")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public Vector3F* VertexNormals;

    [NativeName("vertexSemantics")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public byte* VertexSemantics;

    [NativeName("indexCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public uint IndexCapacityInput;

    [NativeName("indexCountOutput")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public uint IndexCountOutput;

    [NativeName("indices")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public uint* Indices;

    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public SceneSubmeshDataANDROID() { }
}
