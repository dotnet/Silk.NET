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
    public unsafe struct PhysicalDeviceImageFormatInfo2KHR
    {
        public PhysicalDeviceImageFormatInfo2KHR
        (
            StructureType sType = StructureType.PhysicalDeviceImageFormatInfo2,
            void* pNext = default,
            Format format = default,
            ImageType type = default,
            ImageTiling tiling = default,
            ImageUsageFlags usage = default,
            ImageCreateFlags flags = default
        )
        {
           SType = sType;
           PNext = pNext;
           Format = format;
           Type = type;
           Tiling = tiling;
           Usage = usage;
           Flags = flags;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Format Format;
/// <summary></summary>
        public ImageType Type;
/// <summary></summary>
        public ImageTiling Tiling;
/// <summary></summary>
        public ImageUsageFlags Usage;
/// <summary></summary>
        public ImageCreateFlags Flags;
    }
}
