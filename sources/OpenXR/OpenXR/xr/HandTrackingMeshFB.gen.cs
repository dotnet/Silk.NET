// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandTrackingMeshFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HandTrackingMeshFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.HandTrackingMeshFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("jointCapacityInput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public uint JointCapacityInput;

    [NativeName("jointCountOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public uint JointCountOutput;

    [NativeName("jointBindPoses")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public Posef* JointBindPoses;

    [NativeName("jointRadii")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public float* JointRadii;

    [NativeName("jointParents")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandJointEXT* JointParents;

    [NativeName("vertexCapacityInput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public uint VertexCapacityInput;

    [NativeName("vertexCountOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public uint VertexCountOutput;

    [NativeName("vertexPositions")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public Vector3F* VertexPositions;

    [NativeName("vertexNormals")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public Vector3F* VertexNormals;

    [NativeName("vertexUVs")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public Vector2F* VertexUVs;

    [NativeName("vertexBlendIndices")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public Vector4SFB* VertexBlendIndices;

    [NativeName("vertexBlendWeights")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public Vector4F* VertexBlendWeights;

    [NativeName("indexCapacityInput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public uint IndexCapacityInput;

    [NativeName("indexCountOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public uint IndexCountOutput;

    [NativeName("indices")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public short* Indices;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandTrackingMeshFB() { }
}
