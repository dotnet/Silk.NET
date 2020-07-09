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
    [NativeName("Name", "VkSwapchainCreateInfoKHR")]
    public unsafe struct SwapchainCreateInfoKHR
    {
        public SwapchainCreateInfoKHR
        (
            StructureType sType = StructureType.SwapchainCreateInfoKhr,
            void* pNext = default,
            SwapchainCreateFlagsKHR flags = default,
            SurfaceKHR surface = default,
            uint minImageCount = default,
            Format imageFormat = default,
            ColorSpaceKHR imageColorSpace = default,
            Extent2D imageExtent = default,
            uint imageArrayLayers = default,
            ImageUsageFlags imageUsage = default,
            SharingMode imageSharingMode = default,
            uint queueFamilyIndexCount = default,
            uint* pQueueFamilyIndices = default,
            SurfaceTransformFlagsKHR preTransform = default,
            CompositeAlphaFlagsKHR compositeAlpha = default,
            PresentModeKHR presentMode = default,
            Bool32 clipped = default,
            SwapchainKHR oldSwapchain = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Surface = surface;
           MinImageCount = minImageCount;
           ImageFormat = imageFormat;
           ImageColorSpace = imageColorSpace;
           ImageExtent = imageExtent;
           ImageArrayLayers = imageArrayLayers;
           ImageUsage = imageUsage;
           ImageSharingMode = imageSharingMode;
           QueueFamilyIndexCount = queueFamilyIndexCount;
           PQueueFamilyIndices = pQueueFamilyIndices;
           PreTransform = preTransform;
           CompositeAlpha = compositeAlpha;
           PresentMode = presentMode;
           Clipped = clipped;
           OldSwapchain = oldSwapchain;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkSwapchainCreateFlagsKHR")]
        [NativeName("Type.Name", "VkSwapchainCreateFlagsKHR")]
        [NativeName("Name", "flags")]
        public SwapchainCreateFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "VkSurfaceKHR")]
        [NativeName("Type.Name", "VkSurfaceKHR")]
        [NativeName("Name", "surface")]
        public SurfaceKHR Surface;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minImageCount")]
        public uint MinImageCount;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "imageFormat")]
        public Format ImageFormat;
/// <summary></summary>
        [NativeName("Type", "VkColorSpaceKHR")]
        [NativeName("Type.Name", "VkColorSpaceKHR")]
        [NativeName("Name", "imageColorSpace")]
        public ColorSpaceKHR ImageColorSpace;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "imageExtent")]
        public Extent2D ImageExtent;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageArrayLayers")]
        public uint ImageArrayLayers;
/// <summary></summary>
        [NativeName("Type", "VkImageUsageFlags")]
        [NativeName("Type.Name", "VkImageUsageFlags")]
        [NativeName("Name", "imageUsage")]
        public ImageUsageFlags ImageUsage;
/// <summary></summary>
        [NativeName("Type", "VkSharingMode")]
        [NativeName("Type.Name", "VkSharingMode")]
        [NativeName("Name", "imageSharingMode")]
        public SharingMode ImageSharingMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndexCount")]
        public uint QueueFamilyIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pQueueFamilyIndices")]
        public uint* PQueueFamilyIndices;
/// <summary></summary>
        [NativeName("Type", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Type.Name", "VkSurfaceTransformFlagBitsKHR")]
        [NativeName("Name", "preTransform")]
        public SurfaceTransformFlagsKHR PreTransform;
/// <summary></summary>
        [NativeName("Type", "VkCompositeAlphaFlagBitsKHR")]
        [NativeName("Type.Name", "VkCompositeAlphaFlagBitsKHR")]
        [NativeName("Name", "compositeAlpha")]
        public CompositeAlphaFlagsKHR CompositeAlpha;
/// <summary></summary>
        [NativeName("Type", "VkPresentModeKHR")]
        [NativeName("Type.Name", "VkPresentModeKHR")]
        [NativeName("Name", "presentMode")]
        public PresentModeKHR PresentMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "clipped")]
        public Bool32 Clipped;
/// <summary></summary>
        [NativeName("Type", "VkSwapchainKHR")]
        [NativeName("Type.Name", "VkSwapchainKHR")]
        [NativeName("Name", "oldSwapchain")]
        public SwapchainKHR OldSwapchain;
    }
}
