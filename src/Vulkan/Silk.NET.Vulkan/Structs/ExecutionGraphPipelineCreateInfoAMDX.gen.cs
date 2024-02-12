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
    [NativeName("Name", "VkExecutionGraphPipelineCreateInfoAMDX")]
    public unsafe partial struct ExecutionGraphPipelineCreateInfoAMDX : IChainStart
    {
        public ExecutionGraphPipelineCreateInfoAMDX
        (
            StructureType? sType = StructureType.ExecutionGraphPipelineCreateInfoAmdx,
            void* pNext = null,
            PipelineCreateFlags? flags = null,
            uint? stageCount = null,
            PipelineShaderStageCreateInfo* pStages = null,
            PipelineLibraryCreateInfoKHR* pLibraryInfo = null,
            PipelineLayout? layout = null,
            Pipeline? basePipelineHandle = null,
            int? basePipelineIndex = null
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

            if (stageCount is not null)
            {
                StageCount = stageCount.Value;
            }

            if (pStages is not null)
            {
                PStages = pStages;
            }

            if (pLibraryInfo is not null)
            {
                PLibraryInfo = pLibraryInfo;
            }

            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (basePipelineHandle is not null)
            {
                BasePipelineHandle = basePipelineHandle.Value;
            }

            if (basePipelineIndex is not null)
            {
                BasePipelineIndex = basePipelineIndex.Value;
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
        [NativeName("Type", "VkPipelineCreateFlags")]
        [NativeName("Type.Name", "VkPipelineCreateFlags")]
        [NativeName("Name", "flags")]
        public PipelineCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stageCount")]
        public uint StageCount;
/// <summary></summary>
        [NativeName("Type", "VkPipelineShaderStageCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineShaderStageCreateInfo")]
        [NativeName("Name", "pStages")]
        public PipelineShaderStageCreateInfo* PStages;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLibraryCreateInfoKHR*")]
        [NativeName("Type.Name", "VkPipelineLibraryCreateInfoKHR")]
        [NativeName("Name", "pLibraryInfo")]
        public PipelineLibraryCreateInfoKHR* PLibraryInfo;
/// <summary></summary>
        [NativeName("Type", "VkPipelineLayout")]
        [NativeName("Type.Name", "VkPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout Layout;
/// <summary></summary>
        [NativeName("Type", "VkPipeline")]
        [NativeName("Type.Name", "VkPipeline")]
        [NativeName("Name", "basePipelineHandle")]
        public Pipeline BasePipelineHandle;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "basePipelineIndex")]
        public int BasePipelineIndex;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ExecutionGraphPipelineCreateInfoAmdx;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref ExecutionGraphPipelineCreateInfoAMDX Chain(
            out ExecutionGraphPipelineCreateInfoAMDX capture)
        {
            capture = new ExecutionGraphPipelineCreateInfoAMDX(StructureType.ExecutionGraphPipelineCreateInfoAmdx);
            return ref capture;
        }
    }
}
