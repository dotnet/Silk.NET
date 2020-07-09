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
    [NativeName("Name", "VkSpecializationInfo")]
    public unsafe struct SpecializationInfo
    {
        public SpecializationInfo
        (
            uint mapEntryCount = default,
            SpecializationMapEntry* pMapEntries = default,
            UIntPtr dataSize = default,
            void* pData = default
        )
        {
           MapEntryCount = mapEntryCount;
           PMapEntries = pMapEntries;
           DataSize = dataSize;
           PData = pData;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mapEntryCount")]
        public uint MapEntryCount;
/// <summary></summary>
        [NativeName("Type", "VkSpecializationMapEntry*")]
        [NativeName("Type.Name", "VkSpecializationMapEntry")]
        [NativeName("Name", "pMapEntries")]
        public SpecializationMapEntry* PMapEntries;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "dataSize")]
        public UIntPtr DataSize;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pData")]
        public void* PData;
    }
}
