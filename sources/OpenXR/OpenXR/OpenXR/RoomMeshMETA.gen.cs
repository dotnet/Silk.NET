// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRoomMeshMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct RoomMeshMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public StructureType Type = StructureType.RoomMeshMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public void* Next;

    [NativeName("vertexCapacityInput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public uint VertexCapacityInput;

    [NativeName("vertexCountOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public uint VertexCountOutput;

    [NativeName("vertices")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public Vector3F* Vertices;

    [NativeName("faceCapacityInput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public uint FaceCapacityInput;

    [NativeName("faceCountOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public uint FaceCountOutput;

    [NativeName("faces")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public RoomMeshFaceMETA* Faces;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public RoomMeshMETA() { }
}
