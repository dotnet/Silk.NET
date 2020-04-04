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
    public unsafe struct GeneratedCommandsMemoryRequirementsInfoNV
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
        public uint MaxSequencesCount;
    }
}
