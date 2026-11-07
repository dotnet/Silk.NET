// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandMeshMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HandMeshMSFT
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.HandMeshMSFT;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("isActive")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public MaybeBool<uint> IsActive;

    [NativeName("indexBufferChanged")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public MaybeBool<uint> IndexBufferChanged;

    [NativeName("vertexBufferChanged")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public MaybeBool<uint> VertexBufferChanged;

    [NativeName("indexBuffer")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandMeshIndexBufferMSFT IndexBuffer;

    [NativeName("vertexBuffer")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandMeshVertexBufferMSFT VertexBuffer;

    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandMeshMSFT() { }
}
