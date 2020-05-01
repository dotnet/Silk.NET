// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public SwapchainCreateFlagsKHR Flags;
/// <summary></summary>
        public SurfaceKHR Surface;
/// <summary></summary>
        public uint MinImageCount;
/// <summary></summary>
        public Format ImageFormat;
/// <summary></summary>
        public ColorSpaceKHR ImageColorSpace;
/// <summary></summary>
        public Extent2D ImageExtent;
/// <summary></summary>
        public uint ImageArrayLayers;
/// <summary></summary>
        public ImageUsageFlags ImageUsage;
/// <summary></summary>
        public SharingMode ImageSharingMode;
/// <summary></summary>
        public uint QueueFamilyIndexCount;
/// <summary></summary>
        public uint* PQueueFamilyIndices;
/// <summary></summary>
        public SurfaceTransformFlagsKHR PreTransform;
/// <summary></summary>
        public CompositeAlphaFlagsKHR CompositeAlpha;
/// <summary></summary>
        public PresentModeKHR PresentMode;
/// <summary></summary>
        public Bool32 Clipped;
/// <summary></summary>
        public SwapchainKHR OldSwapchain;
    }
}
