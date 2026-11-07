// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPointClippingBehavior")]
public enum PointClippingBehavior : uint
{
    [NativeName("VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES")]
    AllClipPlanes = 0,

    [NativeName("VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY")]
    UserClipPlanesOnly = 1,

    [NativeName("VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES_KHR")]
    AllClipPlanesKHR = AllClipPlanes,

    [NativeName("VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY_KHR")]
    UserClipPlanesOnlyKHR = UserClipPlanesOnly,
}
