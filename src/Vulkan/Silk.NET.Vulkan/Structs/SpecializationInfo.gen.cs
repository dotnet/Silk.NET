// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkSpecializationInfo")]
    public unsafe partial struct SpecializationInfo
    {
        public SpecializationInfo
        (
            uint? mapEntryCount = null,
            SpecializationMapEntry* pMapEntries = null,
            UIntPtr? dataSize = null,
            void* pData = null
        ) : this()
        {
            if (mapEntryCount is not null)
            {
                MapEntryCount = mapEntryCount.Value;
            }

            if (pMapEntries is not null)
            {
                PMapEntries = pMapEntries;
            }

            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }

            if (pData is not null)
            {
                PData = pData;
            }
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
