// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSwapchainCreateInfoKHR")]
    public unsafe partial struct SwapchainCreateInfoKHR : IChainStart
    {
        public SwapchainCreateInfoKHR
        (
            StructureType? sType = StructureType.SwapchainCreateInfoKhr,
            void* pNext = null,
            SwapchainCreateFlagsKHR? flags = null,
            SurfaceKHR? surface = null,
            uint? minImageCount = null,
            Format? imageFormat = null,
            ColorSpaceKHR? imageColorSpace = null,
            Extent2D? imageExtent = null,
            uint? imageArrayLayers = null,
            ImageUsageFlags? imageUsage = null,
            SharingMode? imageSharingMode = null,
            uint? queueFamilyIndexCount = null,
            uint* pQueueFamilyIndices = null,
            SurfaceTransformFlagsKHR? preTransform = null,
            CompositeAlphaFlagsKHR? compositeAlpha = null,
            PresentModeKHR? presentMode = null,
            Bool32? clipped = null,
            SwapchainKHR? oldSwapchain = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (surface is not null)
            {
                Surface = surface.Value;
            }

            if (minImageCount is not null)
            {
                MinImageCount = minImageCount.Value;
            }

            if (imageFormat is not null)
            {
                ImageFormat = imageFormat.Value;
            }

            if (imageColorSpace is not null)
            {
                ImageColorSpace = imageColorSpace.Value;
            }

            if (imageExtent is not null)
            {
                ImageExtent = imageExtent.Value;
            }

            if (imageArrayLayers is not null)
            {
                ImageArrayLayers = imageArrayLayers.Value;
            }

            if (imageUsage is not null)
            {
                ImageUsage = imageUsage.Value;
            }

            if (imageSharingMode is not null)
            {
                ImageSharingMode = imageSharingMode.Value;
            }

            if (queueFamilyIndexCount is not null)
            {
                QueueFamilyIndexCount = queueFamilyIndexCount.Value;
            }

            if (pQueueFamilyIndices is not null)
            {
                PQueueFamilyIndices = pQueueFamilyIndices;
            }

            if (preTransform is not null)
            {
                PreTransform = preTransform.Value;
            }

            if (compositeAlpha is not null)
            {
                CompositeAlpha = compositeAlpha.Value;
            }

            if (presentMode is not null)
            {
                PresentMode = presentMode.Value;
            }

            if (clipped is not null)
            {
                Clipped = clipped.Value;
            }

            if (oldSwapchain is not null)
            {
                OldSwapchain = oldSwapchain.Value;
            }
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SwapchainCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref SwapchainCreateInfoKHR Chain(
            out SwapchainCreateInfoKHR capture)
        {
            capture = new SwapchainCreateInfoKHR(StructureType.SwapchainCreateInfoKhr);
            return ref capture;
        }
    }
}
