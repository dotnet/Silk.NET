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
    public unsafe struct PhysicalDeviceSparseImageFormatInfo2KHR
    {
        public PhysicalDeviceSparseImageFormatInfo2KHR
        (
            StructureType sType = StructureType.PhysicalDeviceSparseImageFormatInfo2,
            void* pNext = default,
            Format format = default,
            ImageType type = default,
            SampleCountFlags samples = default,
            ImageUsageFlags usage = default,
            ImageTiling tiling = default
        )
        {
           SType = sType;
           PNext = pNext;
           Format = format;
           Type = type;
           Samples = samples;
           Usage = usage;
           Tiling = tiling;
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
        public SampleCountFlags Samples;
/// <summary></summary>
        public ImageUsageFlags Usage;
/// <summary></summary>
        public ImageTiling Tiling;
    }
}
