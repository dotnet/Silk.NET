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
    public unsafe struct RenderPassMultiviewCreateInfo
    {
        public RenderPassMultiviewCreateInfo
        (
            StructureType sType = StructureType.RenderPassMultiviewCreateInfo,
            void* pNext = default,
            uint subpassCount = default,
            uint* pViewMasks = default,
            uint dependencyCount = default,
            int* pViewOffsets = default,
            uint correlationMaskCount = default,
            uint* pCorrelationMasks = default
        )
        {
           SType = sType;
           PNext = pNext;
           SubpassCount = subpassCount;
           PViewMasks = pViewMasks;
           DependencyCount = dependencyCount;
           PViewOffsets = pViewOffsets;
           CorrelationMaskCount = correlationMaskCount;
           PCorrelationMasks = pCorrelationMasks;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint SubpassCount;
/// <summary></summary>
        public uint* PViewMasks;
/// <summary></summary>
        public uint DependencyCount;
/// <summary></summary>
        public int* PViewOffsets;
/// <summary></summary>
        public uint CorrelationMaskCount;
/// <summary></summary>
        public uint* PCorrelationMasks;
    }
}
