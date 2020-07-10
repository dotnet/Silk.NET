// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkGeneratedCommandsMemoryRequirementsInfoNV")]
    public unsafe partial struct GeneratedCommandsMemoryRequirementsInfoNV
    {
        public GeneratedCommandsMemoryRequirementsInfoNV
        (
            StructureType sType = StructureType.GeneratedCommandsMemoryRequirementsInfoNV,
            void* pNext = default,
            PipelineBindPoint pipelineBindPoint = default,
            Pipeline pipeline = default,
            IndirectCommandsLayoutNV indirectCommandsLayout = default,
            uint maxSequencesCount = default
        )
        {
            SType = sType;
            PNext = pNext;
            PipelineBindPoint = pipelineBindPoint;
            Pipeline = pipeline;
            IndirectCommandsLayout = indirectCommandsLayout;
            MaxSequencesCount = maxSequencesCount;
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
        [NativeName("Type", "VkPipelineBindPoint")]
        [NativeName("Type.Name", "VkPipelineBindPoint")]
        [NativeName("Name", "pipelineBindPoint")]
        public PipelineBindPoint PipelineBindPoint;
/// <summary></summary>
        [NativeName("Type", "VkPipeline")]
        [NativeName("Type.Name", "VkPipeline")]
        [NativeName("Name", "pipeline")]
        public Pipeline Pipeline;
/// <summary></summary>
        [NativeName("Type", "VkIndirectCommandsLayoutNV")]
        [NativeName("Type.Name", "VkIndirectCommandsLayoutNV")]
        [NativeName("Name", "indirectCommandsLayout")]
        public IndirectCommandsLayoutNV IndirectCommandsLayout;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSequencesCount")]
        public uint MaxSequencesCount;
    }
}
