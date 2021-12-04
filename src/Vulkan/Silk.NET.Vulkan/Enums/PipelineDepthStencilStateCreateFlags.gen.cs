// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkPipelineDepthStencilStateCreateFlags")]
    public enum PipelineDepthStencilStateCreateFlags : int
    {
        [NativeName("Name", "VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_ARM")]
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentDepthAccessBitArm = 1,
        [NativeName("Name", "VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_ARM")]
        PipelineDepthStencilStateCreateRasterizationOrderAttachmentStencilAccessBitArm = 2,
    }
}
