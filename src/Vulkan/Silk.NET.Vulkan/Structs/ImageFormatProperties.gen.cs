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
    [NativeName("Name", "VkImageFormatProperties")]
    public unsafe partial struct ImageFormatProperties
    {
        public ImageFormatProperties
        (
            Extent3D maxExtent = default,
            uint maxMipLevels = default,
            uint maxArrayLayers = default,
            SampleCountFlags sampleCounts = default,
            ulong maxResourceSize = default
        )
        {
            MaxExtent = maxExtent;
            MaxMipLevels = maxMipLevels;
            MaxArrayLayers = maxArrayLayers;
            SampleCounts = sampleCounts;
            MaxResourceSize = maxResourceSize;
        }

/// <summary></summary>
        [NativeName("Type", "VkExtent3D")]
        [NativeName("Type.Name", "VkExtent3D")]
        [NativeName("Name", "maxExtent")]
        public Extent3D MaxExtent;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMipLevels")]
        public uint MaxMipLevels;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxArrayLayers")]
        public uint MaxArrayLayers;
/// <summary></summary>
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "sampleCounts")]
        public SampleCountFlags SampleCounts;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "maxResourceSize")]
        public ulong MaxResourceSize;
    }
}
