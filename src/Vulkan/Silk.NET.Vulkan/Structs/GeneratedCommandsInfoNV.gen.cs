// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct GeneratedCommandsInfoNV
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PipelineBindPoint PipelineBindPoint;
/// <summary></summary>
        public Pipeline Pipeline;
/// <summary></summary>
        public IndirectCommandsLayoutNV IndirectCommandsLayout;
/// <summary></summary>
        public uint StreamCount;
/// <summary></summary>
        public IndirectCommandsStreamNV* PStreams;
/// <summary></summary>
        public uint SequencesCount;
/// <summary></summary>
        public Buffer PreprocessBuffer;
/// <summary></summary>
        public ulong PreprocessOffset;
/// <summary></summary>
        public ulong PreprocessSize;
/// <summary></summary>
        public Buffer SequencesCountBuffer;
/// <summary></summary>
        public ulong SequencesCountOffset;
/// <summary></summary>
        public Buffer SequencesIndexBuffer;
/// <summary></summary>
        public ulong SequencesIndexOffset;
    }
}
