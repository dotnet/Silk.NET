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
    [NativeName("Name", "VkPipelineVertexInputDivisorStateCreateInfoKHR")]
    [NativeName("AliasOf", "VkPipelineVertexInputDivisorStateCreateInfo")]
    public unsafe partial struct PipelineVertexInputDivisorStateCreateInfoKHR : IExtendsChain<PipelineVertexInputStateCreateInfo>
    {
        public PipelineVertexInputDivisorStateCreateInfoKHR
        (
            StructureType? sType = StructureType.PipelineVertexInputDivisorStateCreateInfo,
            void* pNext = null,
            uint? vertexBindingDivisorCount = null,
            VertexInputBindingDivisorDescription* pVertexBindingDivisors = null
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

            if (vertexBindingDivisorCount is not null)
            {
                VertexBindingDivisorCount = vertexBindingDivisorCount.Value;
            }

            if (pVertexBindingDivisors is not null)
            {
                PVertexBindingDivisors = pVertexBindingDivisors;
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
        [NativeName("Name", "vertexBindingDivisorCount")]
        public uint VertexBindingDivisorCount;
/// <summary></summary>
        [NativeName("Type", "VkVertexInputBindingDivisorDescription*")]
        [NativeName("Type.Name", "VkVertexInputBindingDivisorDescription")]
        [NativeName("Name", "pVertexBindingDivisors")]
        public VertexInputBindingDivisorDescription* PVertexBindingDivisors;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineVertexInputDivisorStateCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
