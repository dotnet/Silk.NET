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
    [NativeName("Name", "VkGeneratedCommandsInfoNV")]
    public unsafe partial struct GeneratedCommandsInfoNV
    {
        public GeneratedCommandsInfoNV
        (
            StructureType sType = StructureType.GeneratedCommandsInfoNV,
            void* pNext = default,
            PipelineBindPoint pipelineBindPoint = default,
            Pipeline pipeline = default,
            IndirectCommandsLayoutNV indirectCommandsLayout = default,
            uint streamCount = default,
            IndirectCommandsStreamNV* pStreams = default,
            uint sequencesCount = default,
            Buffer preprocessBuffer = default,
            ulong preprocessOffset = default,
            ulong preprocessSize = default,
            Buffer sequencesCountBuffer = default,
            ulong sequencesCountOffset = default,
            Buffer sequencesIndexBuffer = default,
            ulong sequencesIndexOffset = default
        )
        {
            SType = sType;
            PNext = pNext;
            PipelineBindPoint = pipelineBindPoint;
            Pipeline = pipeline;
            IndirectCommandsLayout = indirectCommandsLayout;
            StreamCount = streamCount;
            PStreams = pStreams;
            SequencesCount = sequencesCount;
            PreprocessBuffer = preprocessBuffer;
            PreprocessOffset = preprocessOffset;
            PreprocessSize = preprocessSize;
            SequencesCountBuffer = sequencesCountBuffer;
            SequencesCountOffset = sequencesCountOffset;
            SequencesIndexBuffer = sequencesIndexBuffer;
            SequencesIndexOffset = sequencesIndexOffset;
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
    }
}
