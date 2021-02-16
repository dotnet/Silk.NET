// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageLayout")]
    public enum ImageLayout : int
    {
        [NativeName("Name", "VK_IMAGE_LAYOUT_UNDEFINED")]
        Undefined = 0,
        [NativeName("Name", "VK_IMAGE_LAYOUT_GENERAL")]
        General = 1,
        [NativeName("Name", "VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL")]
        ColorAttachmentOptimal = 2,
        [NativeName("Name", "VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL")]
        DepthStencilAttachmentOptimal = 3,
        [NativeName("Name", "VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL")]
        DepthStencilReadOnlyOptimal = 4,
        [NativeName("Name", "VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL")]
        ShaderReadOnlyOptimal = 5,
        [NativeName("Name", "VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL")]
        TransferSrcOptimal = 6,
        [NativeName("Name", "VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL")]
        TransferDstOptimal = 7,
        [NativeName("Name", "VK_IMAGE_LAYOUT_PREINITIALIZED")]
        Preinitialized = 8,
        [NativeName("Name", "VK_IMAGE_LAYOUT_PRESENT_SRC_KHR")]
        PresentSrcKhr = 1000001002,
        [NativeName("Name", "VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR")]
        SharedPresentKhr = 1000111000,
        [NativeName("Name", "VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL_KHR")]
        DepthReadOnlyStencilAttachmentOptimalKhr = 1000117000,
        [NativeName("Name", "VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL_KHR")]
        DepthAttachmentStencilReadOnlyOptimalKhr = 1000117001,
        [NativeName("Name", "VK_IMAGE_LAYOUT_SHADING_RATE_OPTIMAL_NV")]
        ShadingRateOptimalNV = 1000164003,
        [NativeName("Name", "VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT")]
        FragmentDensityMapOptimalExt = 1000218000,
        [NativeName("Name", "VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR")]
        FragmentShadingRateAttachmentOptimalKhr = 1000226003,
        [NativeName("Name", "VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL_KHR")]
        DepthAttachmentOptimalKhr = 1000241000,
        [NativeName("Name", "VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL_KHR")]
        DepthReadOnlyOptimalKhr = 1000241001,
        [NativeName("Name", "VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL_KHR")]
        StencilAttachmentOptimalKhr = 1000241002,
        [NativeName("Name", "VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL_KHR")]
        StencilReadOnlyOptimalKhr = 1000241003,
        [NativeName("Name", "VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL")]
        DepthReadOnlyStencilAttachmentOptimal = 1000117000,
        [NativeName("Name", "VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL")]
        DepthAttachmentStencilReadOnlyOptimal = 1000117001,
        [NativeName("Name", "VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL")]
        DepthAttachmentOptimal = 1000241000,
        [NativeName("Name", "VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL")]
        DepthReadOnlyOptimal = 1000241001,
        [NativeName("Name", "VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL")]
        StencilAttachmentOptimal = 1000241002,
        [NativeName("Name", "VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL")]
        StencilReadOnlyOptimal = 1000241003,
    }
}
