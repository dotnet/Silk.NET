// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVisibilityMaskTypeKHR")]
[SupportedApiProfile("openxr")]
public enum VisibilityMaskTypeKHR : uint
{
    [NativeName("XR_VISIBILITY_MASK_TYPE_HIDDEN_TRIANGLE_MESH_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    HiddenTriangleMesh = 1,

    [NativeName("XR_VISIBILITY_MASK_TYPE_VISIBLE_TRIANGLE_MESH_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    VisibleTriangleMesh = 2,

    [NativeName("XR_VISIBILITY_MASK_TYPE_LINE_LOOP_KHR")]
    [SupportedApiProfile("openxr", ["XR_KHR_visibility_mask"])]
    LineLoop = 3,
}
