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
    public unsafe struct PipelineDepthStencilStateCreateInfo
    {
        public PipelineDepthStencilStateCreateInfo
        (
            StructureType sType = StructureType.PipelineDepthStencilStateCreateInfo,
            void* pNext = default,
            uint flags = default,
            Bool32 depthTestEnable = default,
            Bool32 depthWriteEnable = default,
            CompareOp depthCompareOp = default,
            Bool32 depthBoundsTestEnable = default,
            Bool32 stencilTestEnable = default,
            StencilOpState front = default,
            StencilOpState back = default,
            float minDepthBounds = default,
            float maxDepthBounds = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           DepthTestEnable = depthTestEnable;
           DepthWriteEnable = depthWriteEnable;
           DepthCompareOp = depthCompareOp;
           DepthBoundsTestEnable = depthBoundsTestEnable;
           StencilTestEnable = stencilTestEnable;
           Front = front;
           Back = back;
           MinDepthBounds = minDepthBounds;
           MaxDepthBounds = maxDepthBounds;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public Bool32 DepthTestEnable;
/// <summary></summary>
        public Bool32 DepthWriteEnable;
/// <summary></summary>
        public CompareOp DepthCompareOp;
/// <summary></summary>
        public Bool32 DepthBoundsTestEnable;
/// <summary></summary>
        public Bool32 StencilTestEnable;
/// <summary></summary>
        public StencilOpState Front;
/// <summary></summary>
        public StencilOpState Back;
/// <summary></summary>
        public float MinDepthBounds;
/// <summary></summary>
        public float MaxDepthBounds;
    }
}
