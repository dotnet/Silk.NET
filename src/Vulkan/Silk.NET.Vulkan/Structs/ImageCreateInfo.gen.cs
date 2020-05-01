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
    public unsafe struct ImageCreateInfo
    {
        public ImageCreateInfo
        (
            StructureType sType = StructureType.ImageCreateInfo,
            void* pNext = default,
            ImageCreateFlags flags = default,
            ImageType imageType = default,
            Format format = default,
            Extent3D extent = default,
            uint mipLevels = default,
            uint arrayLayers = default,
            SampleCountFlags samples = default,
            ImageTiling tiling = default,
            ImageUsageFlags usage = default,
            SharingMode sharingMode = default,
            uint queueFamilyIndexCount = default,
            uint* pQueueFamilyIndices = default,
            ImageLayout initialLayout = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           ImageType = imageType;
           Format = format;
           Extent = extent;
           MipLevels = mipLevels;
           ArrayLayers = arrayLayers;
           Samples = samples;
           Tiling = tiling;
           Usage = usage;
           SharingMode = sharingMode;
           QueueFamilyIndexCount = queueFamilyIndexCount;
           PQueueFamilyIndices = pQueueFamilyIndices;
           InitialLayout = initialLayout;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ImageCreateFlags Flags;
/// <summary></summary>
        public ImageType ImageType;
/// <summary></summary>
        public Format Format;
/// <summary></summary>
        public Extent3D Extent;
/// <summary></summary>
        public uint MipLevels;
/// <summary></summary>
        public uint ArrayLayers;
/// <summary></summary>
        public SampleCountFlags Samples;
/// <summary></summary>
        public ImageTiling Tiling;
/// <summary></summary>
        public ImageUsageFlags Usage;
/// <summary></summary>
        public SharingMode SharingMode;
/// <summary></summary>
        public uint QueueFamilyIndexCount;
/// <summary></summary>
        public uint* PQueueFamilyIndices;
/// <summary></summary>
        public ImageLayout InitialLayout;
    }
}
