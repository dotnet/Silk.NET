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
    [NativeName("Name", "VkGeneratedCommandsMemoryRequirementsInfoNV")]
    public unsafe partial struct GeneratedCommandsMemoryRequirementsInfoNV : IChainable
    {
        public GeneratedCommandsMemoryRequirementsInfoNV
        (
            StructureType? sType = StructureType.GeneratedCommandsMemoryRequirementsInfoNV,
            void* pNext = null,
            PipelineBindPoint? pipelineBindPoint = null,
            Pipeline? pipeline = null,
            IndirectCommandsLayoutNV? indirectCommandsLayout = null,
            uint? maxSequencesCount = null
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

            if (pipelineBindPoint is not null)
            {
                PipelineBindPoint = pipelineBindPoint.Value;
            }

            if (pipeline is not null)
            {
                Pipeline = pipeline.Value;
            }

            if (indirectCommandsLayout is not null)
            {
                IndirectCommandsLayout = indirectCommandsLayout.Value;
            }

            if (maxSequencesCount is not null)
            {
                MaxSequencesCount = maxSequencesCount.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.GeneratedCommandsMemoryRequirementsInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
