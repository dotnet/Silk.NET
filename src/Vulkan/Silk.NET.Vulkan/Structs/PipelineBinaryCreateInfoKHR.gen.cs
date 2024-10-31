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
    [NativeName("Name", "VkPipelineBinaryCreateInfoKHR")]
    public unsafe partial struct PipelineBinaryCreateInfoKHR : IChainable
    {
        public PipelineBinaryCreateInfoKHR
        (
            StructureType? sType = StructureType.PipelineBinaryCreateInfoKhr,
            void* pNext = null,
            PipelineBinaryKeysAndDataKHR* pKeysAndDataInfo = null,
            Pipeline? pipeline = null,
            PipelineCreateInfoKHR* pPipelineCreateInfo = null
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

            if (pKeysAndDataInfo is not null)
            {
                PKeysAndDataInfo = pKeysAndDataInfo;
            }

            if (pipeline is not null)
            {
                Pipeline = pipeline.Value;
            }

            if (pPipelineCreateInfo is not null)
            {
                PPipelineCreateInfo = pPipelineCreateInfo;
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
        [NativeName("Type", "VkPipelineBinaryKeysAndDataKHR*")]
        [NativeName("Type.Name", "VkPipelineBinaryKeysAndDataKHR")]
        [NativeName("Name", "pKeysAndDataInfo")]
        public PipelineBinaryKeysAndDataKHR* PKeysAndDataInfo;
/// <summary></summary>
        [NativeName("Type", "VkPipeline")]
        [NativeName("Type.Name", "VkPipeline")]
        [NativeName("Name", "pipeline")]
        public Pipeline Pipeline;
/// <summary></summary>
        [NativeName("Type", "VkPipelineCreateInfoKHR*")]
        [NativeName("Type.Name", "VkPipelineCreateInfoKHR")]
        [NativeName("Name", "pPipelineCreateInfo")]
        public PipelineCreateInfoKHR* PPipelineCreateInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineBinaryCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
