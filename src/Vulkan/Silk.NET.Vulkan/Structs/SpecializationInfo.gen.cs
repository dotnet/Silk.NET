// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
            nuint? dataSize = null,
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
        public nuint DataSize;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pData")]
        public void* PData;
    }
}
