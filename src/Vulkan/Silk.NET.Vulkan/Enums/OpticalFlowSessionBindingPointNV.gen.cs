// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkOpticalFlowSessionBindingPointNV")]
    public enum OpticalFlowSessionBindingPointNV : int
    {
        [Obsolete("Deprecated in favour of \"UnknownNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_UNKNOWN_NV")]
        OpticalFlowSessionBindingPointUnknownNV = 0,
        [Obsolete("Deprecated in favour of \"InputNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_INPUT_NV")]
        OpticalFlowSessionBindingPointInputNV = 1,
        [Obsolete("Deprecated in favour of \"ReferenceNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_REFERENCE_NV")]
        OpticalFlowSessionBindingPointReferenceNV = 2,
        [Obsolete("Deprecated in favour of \"HintNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV")]
        OpticalFlowSessionBindingPointHintNV = 3,
        [Obsolete("Deprecated in favour of \"FlowVectorNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_FLOW_VECTOR_NV")]
        OpticalFlowSessionBindingPointFlowVectorNV = 4,
        [Obsolete("Deprecated in favour of \"BackwardFlowVectorNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_FLOW_VECTOR_NV")]
        OpticalFlowSessionBindingPointBackwardFlowVectorNV = 5,
        [Obsolete("Deprecated in favour of \"CostNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV")]
        OpticalFlowSessionBindingPointCostNV = 6,
        [Obsolete("Deprecated in favour of \"BackwardCostNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV")]
        OpticalFlowSessionBindingPointBackwardCostNV = 7,
        [Obsolete("Deprecated in favour of \"GlobalFlowNV\"")]
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV")]
        OpticalFlowSessionBindingPointGlobalFlowNV = 8,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_UNKNOWN_NV")]
        UnknownNV = 0,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_INPUT_NV")]
        InputNV = 1,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_REFERENCE_NV")]
        ReferenceNV = 2,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV")]
        HintNV = 3,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_FLOW_VECTOR_NV")]
        FlowVectorNV = 4,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_FLOW_VECTOR_NV")]
        BackwardFlowVectorNV = 5,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV")]
        CostNV = 6,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV")]
        BackwardCostNV = 7,
        [NativeName("Name", "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV")]
        GlobalFlowNV = 8,
    }
}
