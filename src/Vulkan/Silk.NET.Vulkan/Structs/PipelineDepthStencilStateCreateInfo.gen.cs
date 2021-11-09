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
    [NativeName("Name", "VkPipelineDepthStencilStateCreateInfo")]
    public unsafe partial struct PipelineDepthStencilStateCreateInfo : IChainable
    {
        public PipelineDepthStencilStateCreateInfo
        (
            StructureType? sType = StructureType.PipelineDepthStencilStateCreateInfo,
            void* pNext = null,
            uint? flags = null,
            Bool32? depthTestEnable = null,
            Bool32? depthWriteEnable = null,
            CompareOp? depthCompareOp = null,
            Bool32? depthBoundsTestEnable = null,
            Bool32? stencilTestEnable = null,
            StencilOpState? front = null,
            StencilOpState? back = null,
            float? minDepthBounds = null,
            float? maxDepthBounds = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (depthTestEnable is not null)
            {
                DepthTestEnable = depthTestEnable.Value;
            }

            if (depthWriteEnable is not null)
            {
                DepthWriteEnable = depthWriteEnable.Value;
            }

            if (depthCompareOp is not null)
            {
                DepthCompareOp = depthCompareOp.Value;
            }

            if (depthBoundsTestEnable is not null)
            {
                DepthBoundsTestEnable = depthBoundsTestEnable.Value;
            }

            if (stencilTestEnable is not null)
            {
                StencilTestEnable = stencilTestEnable.Value;
            }

            if (front is not null)
            {
                Front = front.Value;
            }

            if (back is not null)
            {
                Back = back.Value;
            }

            if (minDepthBounds is not null)
            {
                MinDepthBounds = minDepthBounds.Value;
            }

            if (maxDepthBounds is not null)
            {
                MaxDepthBounds = maxDepthBounds.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineDepthStencilStateCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
