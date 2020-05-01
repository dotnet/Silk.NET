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
    public unsafe struct SamplerYcbcrConversionImageFormatPropertiesKHR
    {
        public SamplerYcbcrConversionImageFormatPropertiesKHR
        (
            StructureType sType = StructureType.SamplerYcbcrConversionImageFormatProperties,
            void* pNext = default,
            uint combinedImageSamplerDescriptorCount = default
        )
        {
           SType = sType;
           PNext = pNext;
           CombinedImageSamplerDescriptorCount = combinedImageSamplerDescriptorCount;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint CombinedImageSamplerDescriptorCount;
    }
}
