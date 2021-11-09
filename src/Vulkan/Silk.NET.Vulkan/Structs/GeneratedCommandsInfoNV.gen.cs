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
    [NativeName("Name", "VkGeneratedCommandsInfoNV")]
    public unsafe partial struct GeneratedCommandsInfoNV : IChainable
    {
        public GeneratedCommandsInfoNV
        (
            StructureType? sType = StructureType.GeneratedCommandsInfoNV,
            void* pNext = null,
            PipelineBindPoint? pipelineBindPoint = null,
            Pipeline? pipeline = null,
            IndirectCommandsLayoutNV? indirectCommandsLayout = null,
            uint? streamCount = null,
            IndirectCommandsStreamNV* pStreams = null,
            uint? sequencesCount = null,
            Buffer? preprocessBuffer = null,
            ulong? preprocessOffset = null,
            ulong? preprocessSize = null,
            Buffer? sequencesCountBuffer = null,
            ulong? sequencesCountOffset = null,
            Buffer? sequencesIndexBuffer = null,
            ulong? sequencesIndexOffset = null
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

            if (streamCount is not null)
            {
                StreamCount = streamCount.Value;
            }

            if (pStreams is not null)
            {
                PStreams = pStreams;
            }

            if (sequencesCount is not null)
            {
                SequencesCount = sequencesCount.Value;
            }

            if (preprocessBuffer is not null)
            {
                PreprocessBuffer = preprocessBuffer.Value;
            }

            if (preprocessOffset is not null)
            {
                PreprocessOffset = preprocessOffset.Value;
            }

            if (preprocessSize is not null)
            {
                PreprocessSize = preprocessSize.Value;
            }

            if (sequencesCountBuffer is not null)
            {
                SequencesCountBuffer = sequencesCountBuffer.Value;
            }

            if (sequencesCountOffset is not null)
            {
                SequencesCountOffset = sequencesCountOffset.Value;
            }

            if (sequencesIndexBuffer is not null)
            {
                SequencesIndexBuffer = sequencesIndexBuffer.Value;
            }

            if (sequencesIndexOffset is not null)
            {
                SequencesIndexOffset = sequencesIndexOffset.Value;
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
        [NativeName("Name", "streamCount")]
        public uint StreamCount;
/// <summary></summary>
        [NativeName("Type", "VkIndirectCommandsStreamNV*")]
        [NativeName("Type.Name", "VkIndirectCommandsStreamNV")]
        [NativeName("Name", "pStreams")]
        public IndirectCommandsStreamNV* PStreams;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sequencesCount")]
        public uint SequencesCount;
/// <summary></summary>
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "preprocessBuffer")]
        public Buffer PreprocessBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "preprocessOffset")]
        public ulong PreprocessOffset;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "preprocessSize")]
        public ulong PreprocessSize;
/// <summary></summary>
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "sequencesCountBuffer")]
        public Buffer SequencesCountBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "sequencesCountOffset")]
        public ulong SequencesCountOffset;
/// <summary></summary>
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "sequencesIndexBuffer")]
        public Buffer SequencesIndexBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "sequencesIndexOffset")]
        public ulong SequencesIndexOffset;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.GeneratedCommandsInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
