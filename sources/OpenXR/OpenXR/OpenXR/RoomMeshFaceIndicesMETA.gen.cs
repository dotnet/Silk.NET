// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRoomMeshFaceIndicesMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct RoomMeshFaceIndicesMETA
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
    public StructureType Type = StructureType.RoomMeshFaceIndicesMETA;

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

    [NativeName("indexCapacityInput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public uint IndexCapacityInput;

    [NativeName("indexCountOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public uint IndexCountOutput;

    [NativeName("indices")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public uint* Indices;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    public RoomMeshFaceIndicesMETA() { }
}
