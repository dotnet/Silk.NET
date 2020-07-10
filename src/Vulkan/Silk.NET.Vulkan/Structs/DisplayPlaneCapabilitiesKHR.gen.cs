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
    [NativeName("Name", "VkDisplayPlaneCapabilitiesKHR")]
    public unsafe partial struct DisplayPlaneCapabilitiesKHR
    {
        public DisplayPlaneCapabilitiesKHR
        (
            DisplayPlaneAlphaFlagsKHR supportedAlpha = default,
            Offset2D minSrcPosition = default,
            Offset2D maxSrcPosition = default,
            Extent2D minSrcExtent = default,
            Extent2D maxSrcExtent = default,
            Offset2D minDstPosition = default,
            Offset2D maxDstPosition = default,
            Extent2D minDstExtent = default,
            Extent2D maxDstExtent = default
        )
        {
            SupportedAlpha = supportedAlpha;
            MinSrcPosition = minSrcPosition;
            MaxSrcPosition = maxSrcPosition;
            MinSrcExtent = minSrcExtent;
            MaxSrcExtent = maxSrcExtent;
            MinDstPosition = minDstPosition;
            MaxDstPosition = maxDstPosition;
            MinDstExtent = minDstExtent;
            MaxDstExtent = maxDstExtent;
        }

/// <summary></summary>
        [NativeName("Type", "VkDisplayPlaneAlphaFlagsKHR")]
        [NativeName("Type.Name", "VkDisplayPlaneAlphaFlagsKHR")]
        [NativeName("Name", "supportedAlpha")]
        public DisplayPlaneAlphaFlagsKHR SupportedAlpha;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "minSrcPosition")]
        public Offset2D MinSrcPosition;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "maxSrcPosition")]
        public Offset2D MaxSrcPosition;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minSrcExtent")]
        public Extent2D MinSrcExtent;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxSrcExtent")]
        public Extent2D MaxSrcExtent;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "minDstPosition")]
        public Offset2D MinDstPosition;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "maxDstPosition")]
        public Offset2D MaxDstPosition;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minDstExtent")]
        public Extent2D MinDstExtent;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxDstExtent")]
        public Extent2D MaxDstExtent;
    }
}
