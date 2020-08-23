// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineCacheCreateInfo")]
    public unsafe partial struct PipelineCacheCreateInfo
    {
        public PipelineCacheCreateInfo
        (
            StructureType sType = StructureType.PipelineCacheCreateInfo,
            void* pNext = default,
            PipelineCacheCreateFlags flags = default,
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
        [NativeName("Type", "VkPipelineCacheCreateFlags")]
        [NativeName("Type.Name", "VkPipelineCacheCreateFlags")]
        [NativeName("Name", "flags")]
        public PipelineCacheCreateFlags Flags;
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
