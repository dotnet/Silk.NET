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
    [NativeName("Name", "VkPipelineDepthStencilStateCreateInfo")]
    public unsafe partial struct PipelineDepthStencilStateCreateInfo
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
        [NativeName("Type", "VkPipelineDepthStencilStateCreateFlags")]
        [NativeName("Type.Name", "VkPipelineDepthStencilStateCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthTestEnable")]
        public Bool32 DepthTestEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthWriteEnable")]
        public Bool32 DepthWriteEnable;
/// <summary></summary>
        [NativeName("Type", "VkCompareOp")]
        [NativeName("Type.Name", "VkCompareOp")]
        [NativeName("Name", "depthCompareOp")]
        public CompareOp DepthCompareOp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthBoundsTestEnable")]
        public Bool32 DepthBoundsTestEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "stencilTestEnable")]
        public Bool32 StencilTestEnable;
/// <summary></summary>
        [NativeName("Type", "VkStencilOpState")]
        [NativeName("Type.Name", "VkStencilOpState")]
        [NativeName("Name", "front")]
        public StencilOpState Front;
/// <summary></summary>
        [NativeName("Type", "VkStencilOpState")]
        [NativeName("Type.Name", "VkStencilOpState")]
        [NativeName("Name", "back")]
        public StencilOpState Back;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minDepthBounds")]
        public float MinDepthBounds;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxDepthBounds")]
        public float MaxDepthBounds;
    }
}
