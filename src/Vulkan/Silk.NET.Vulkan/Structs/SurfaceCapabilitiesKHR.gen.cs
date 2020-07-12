// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSurfaceCapabilitiesKHR")]
    public unsafe partial struct SurfaceCapabilitiesKHR
    {
        public SurfaceCapabilitiesKHR
        (
            uint minImageCount = default,
            uint maxImageCount = default,
            Extent2D currentExtent = default,
            Extent2D minImageExtent = default,
            Extent2D maxImageExtent = default,
            uint maxImageArrayLayers = default,
            SurfaceTransformFlagsKHR supportedTransforms = default,
            SurfaceTransformFlagsKHR currentTransform = default,
            CompositeAlphaFlagsKHR supportedCompositeAlpha = default,
            ImageUsageFlags supportedUsageFlags = default
        )
        {
            MinImageCount = minImageCount;
            MaxImageCount = maxImageCount;
            CurrentExtent = currentExtent;
            MinImageExtent = minImageExtent;
            MaxImageExtent = maxImageExtent;
            MaxImageArrayLayers = maxImageArrayLayers;
            SupportedTransforms = supportedTransforms;
            CurrentTransform = currentTransform;
            SupportedCompositeAlpha = supportedCompositeAlpha;
            SupportedUsageFlags = supportedUsageFlags;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minImageCount")]
        public uint MinImageCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImageCount")]
        public uint MaxImageCount;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "currentExtent")]
        public Extent2D CurrentExtent;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minImageExtent")]
        public Extent2D MinImageExtent;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxImageExtent")]
        public Extent2D MaxImageExtent;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxImageArrayLayers")]
        public uint MaxImageArrayLayers;
/// <summary></summary>
        [NativeName("Type", "VkSurfaceTransformFlagsKHR")]
        [NativeName("Type.Name", "VkSurfaceTransformFlagsKHR")]
        [NativeName("Name", "supportedTransforms")]
        public SurfaceTransformFlagsKHR SupportedTransforms;
/// <summary></summary>
        [NativeName("Type", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Type.Name", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Name", "currentTransform")]
        public SurfaceTransformFlagsKHR CurrentTransform;
/// <summary></summary>
        [NativeName("Type", "VkCompositeAlphaFlagsKHR")]
        [NativeName("Type.Name", "VkCompositeAlphaFlagsKHR")]
        [NativeName("Name", "supportedCompositeAlpha")]
        public CompositeAlphaFlagsKHR SupportedCompositeAlpha;
/// <summary></summary>
        [NativeName("Type", "VkImageUsageFlags")]
        [NativeName("Type.Name", "VkImageUsageFlags")]
        [NativeName("Name", "supportedUsageFlags")]
        public ImageUsageFlags SupportedUsageFlags;
    }
}
