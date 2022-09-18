// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPipelineDepthStencilStateCreateFlags")]
    public enum PipelineDepthStencilStateCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DepthAccessBitArm\"")]
        [NativeName("Name", "VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM")]
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentDepthAccessBitArm = 1,
        [Obsolete("Deprecated in favour of \"StencilAccessBitArm\"")]
        [NativeName("Name", "VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM")]
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentStencilAccessBitArm = 2,
        [Obsolete("Deprecated in favour of \"DepthAccessBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT")]
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentDepthAccessBitExt = 1,
        [Obsolete("Deprecated in favour of \"StencilAccessBitExt\"")]
        [NativeName("Name", "VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT")]
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentStencilAccessBitExt = 2,
        [NativeName("Name", "VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM")]
        DepthAccessBitArm = 1,
        [NativeName("Name", "VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM")]
        StencilAccessBitArm = 2,
        [NativeName("Name", "VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT")]
        DepthAccessBitExt = 1,
        [NativeName("Name", "VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT")]
        StencilAccessBitExt = 2,
    }
}
