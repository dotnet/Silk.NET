// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM
{
    [SupportedApiProfile("vulkan", ["VK_QCOM_multiview_per_view_render_areas"])]
    public StructureType SType;

    [SupportedApiProfile("vulkan", ["VK_QCOM_multiview_per_view_render_areas"])]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_multiview_per_view_render_areas"])]
    public uint MultiviewPerViewRenderAreas;
}
