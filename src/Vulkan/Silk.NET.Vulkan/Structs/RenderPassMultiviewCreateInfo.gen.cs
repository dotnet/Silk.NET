// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRenderPassMultiviewCreateInfo")]
    public unsafe partial struct RenderPassMultiviewCreateInfo
    {
        public RenderPassMultiviewCreateInfo
        (
            StructureType? sType = StructureType.RenderPassMultiviewCreateInfo,
            void* pNext = null,
            uint? subpassCount = null,
            uint* pViewMasks = null,
            uint? dependencyCount = null,
            int* pViewOffsets = null,
            uint? correlationMaskCount = null,
            uint* pCorrelationMasks = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (subpassCount is not null)
            {
                SubpassCount = subpassCount.Value;
            }

            if (pViewMasks is not null)
            {
                PViewMasks = pViewMasks;
            }

            if (dependencyCount is not null)
            {
                DependencyCount = dependencyCount.Value;
            }

            if (pViewOffsets is not null)
            {
                PViewOffsets = pViewOffsets;
            }

            if (correlationMaskCount is not null)
            {
                CorrelationMaskCount = correlationMaskCount.Value;
            }

            if (pCorrelationMasks is not null)
            {
                PCorrelationMasks = pCorrelationMasks;
            }
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "subpassCount")]
        public uint SubpassCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pViewMasks")]
        public uint* PViewMasks;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dependencyCount")]
        public uint DependencyCount;
/// <summary></summary>
        [NativeName("Type", "int32_t*")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "pViewOffsets")]
        public int* PViewOffsets;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "correlationMaskCount")]
        public uint CorrelationMaskCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pCorrelationMasks")]
        public uint* PCorrelationMasks;
    }
}
