// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkOpticalFlowSessionBindingPointNV")]
public enum OpticalFlowSessionBindingPointNV : uint
{
    [NativeName("VK_OPTICAL_FLOW_SESSION_BINDING_POINT_UNKNOWN_NV")]
    Unknown = 0,

    [NativeName("VK_OPTICAL_FLOW_SESSION_BINDING_POINT_INPUT_NV")]
    Input = 1,

    [NativeName("VK_OPTICAL_FLOW_SESSION_BINDING_POINT_REFERENCE_NV")]
    Reference = 2,

    [NativeName("VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV")]
    Hint = 3,

    [NativeName("VK_OPTICAL_FLOW_SESSION_BINDING_POINT_FLOW_VECTOR_NV")]
    FlowVector = 4,

    [NativeName("VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_FLOW_VECTOR_NV")]
    BackwardFlowVector = 5,

    [NativeName("VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV")]
    Cost = 6,

    [NativeName("VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV")]
    BackwardCost = 7,

    [NativeName("VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV")]
    GlobalFlow = 8,
}
