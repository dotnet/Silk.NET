// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVisibilityMaskKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct VisibilityMaskKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public StructureType Type = StructureType.TypeVisibilityMaskKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public void* Next;

    [NativeName("vertexCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public uint VertexCapacityInput;

    [NativeName("vertexCountOutput")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public uint VertexCountOutput;

    [NativeName("vertices")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public Vector2F* Vertices;

    [NativeName("indexCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public uint IndexCapacityInput;

    [NativeName("indexCountOutput")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public uint IndexCountOutput;

    [NativeName("indices")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public uint* Indices;

    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    public VisibilityMaskKHR() { }
}
