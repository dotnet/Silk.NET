// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandMeshVertexBufferMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HandMeshVertexBufferMSFT
{
    [NativeName("vertexUpdateTime")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public long VertexUpdateTime;

    [NativeName("vertexCapacityInput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public uint VertexCapacityInput;

    [NativeName("vertexCountOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public uint VertexCountOutput;

    [NativeName("vertices")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandMeshVertexMSFT* Vertices;
}
