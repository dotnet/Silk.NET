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
    [NativeName("Name", "VkValidationCacheCreateInfoEXT")]
    public unsafe struct ValidationCacheCreateInfoEXT
    {
        public ValidationCacheCreateInfoEXT
        (
            StructureType sType = StructureType.ValidationCacheCreateInfoExt,
            void* pNext = default,
            uint flags = default,
            UIntPtr initialDataSize = default,
            void* pInitialData = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           InitialDataSize = initialDataSize;
           PInitialData = pInitialData;
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
        [NativeName("Type", "VkValidationCacheCreateFlagsEXT")]
        [NativeName("Type.Name", "VkValidationCacheCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "initialDataSize")]
        public UIntPtr InitialDataSize;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pInitialData")]
        public void* PInitialData;
    }
}
