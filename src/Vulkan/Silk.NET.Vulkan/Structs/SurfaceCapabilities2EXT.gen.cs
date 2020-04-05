// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct SurfaceCapabilities2EXT
    {
        public SurfaceCapabilities2EXT
        (
            StructureType sType = StructureType.SurfaceCapabilities2Ext,
            void* pNext = default,
            uint minImageCount = default,
            uint maxImageCount = default,
            Extent2D currentExtent = default,
            Extent2D minImageExtent = default,
            Extent2D maxImageExtent = default,
            uint maxImageArrayLayers = default,
            SurfaceTransformFlagsKHR supportedTransforms = default,
            SurfaceTransformFlagsKHR currentTransform = default,
            CompositeAlphaFlagsKHR supportedCompositeAlpha = default,
            ImageUsageFlags supportedUsageFlags = default,
            SurfaceCounterFlagsEXT supportedSurfaceCounters = default
        )
        {
           SType = sType;
           PNext = pNext;
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
           SupportedSurfaceCounters = supportedSurfaceCounters;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MinImageCount;
/// <summary></summary>
        public uint MaxImageCount;
/// <summary></summary>
        public Extent2D CurrentExtent;
/// <summary></summary>
        public Extent2D MinImageExtent;
/// <summary></summary>
        public Extent2D MaxImageExtent;
/// <summary></summary>
        public uint MaxImageArrayLayers;
/// <summary></summary>
        public SurfaceTransformFlagsKHR SupportedTransforms;
/// <summary></summary>
        public SurfaceTransformFlagsKHR CurrentTransform;
/// <summary></summary>
        public CompositeAlphaFlagsKHR SupportedCompositeAlpha;
/// <summary></summary>
        public ImageUsageFlags SupportedUsageFlags;
/// <summary></summary>
        public SurfaceCounterFlagsEXT SupportedSurfaceCounters;
    }
}
