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
    [NativeName("Name", "VkPipelineBinaryInfoKHR")]
    public unsafe partial struct PipelineBinaryInfoKHR : IExtendsChain<GraphicsPipelineCreateInfo>, IExtendsChain<ComputePipelineCreateInfo>, IExtendsChain<RayTracingPipelineCreateInfoKHR>
    {
        public PipelineBinaryInfoKHR
        (
            StructureType? sType = StructureType.PipelineBinaryInfoKhr,
            void* pNext = null,
            uint? binaryCount = null,
            PipelineBinaryKHR* pPipelineBinaries = null
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

            if (binaryCount is not null)
            {
                BinaryCount = binaryCount.Value;
            }

            if (pPipelineBinaries is not null)
            {
                PPipelineBinaries = pPipelineBinaries;
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
        [NativeName("Name", "binaryCount")]
        public uint BinaryCount;
/// <summary></summary>
        [NativeName("Type", "VkPipelineBinaryKHR*")]
        [NativeName("Type.Name", "VkPipelineBinaryKHR")]
        [NativeName("Name", "pPipelineBinaries")]
        public PipelineBinaryKHR* PPipelineBinaries;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineBinaryInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
