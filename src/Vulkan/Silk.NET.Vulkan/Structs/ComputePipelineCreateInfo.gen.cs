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
    [NativeName("Name", "VkComputePipelineCreateInfo")]
    public unsafe partial struct ComputePipelineCreateInfo
    {
        public ComputePipelineCreateInfo
        (
            StructureType? sType = StructureType.ComputePipelineCreateInfo,
            void* pNext = null,
            PipelineCreateFlags? flags = null,
            PipelineShaderStageCreateInfo? stage = null,
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

            if (stage is not null)
            {
                Stage = stage.Value;
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
        [NativeName("Type", "VkPipelineShaderStageCreateInfo")]
        [NativeName("Type.Name", "VkPipelineShaderStageCreateInfo")]
        [NativeName("Name", "stage")]
        public PipelineShaderStageCreateInfo Stage;
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
    }
}
