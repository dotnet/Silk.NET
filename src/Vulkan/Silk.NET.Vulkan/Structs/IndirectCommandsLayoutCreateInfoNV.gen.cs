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
    public unsafe struct IndirectCommandsLayoutCreateInfoNV
    {
        public IndirectCommandsLayoutCreateInfoNV
        (
            StructureType sType = StructureType.IndirectCommandsLayoutCreateInfoNV,
            void* pNext = default,
            IndirectCommandsLayoutUsageFlagsNV flags = default,
            PipelineBindPoint pipelineBindPoint = default,
            uint tokenCount = default,
            IndirectCommandsLayoutTokenNV* pTokens = default,
            uint streamCount = default,
            uint* pStreamStrides = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           PipelineBindPoint = pipelineBindPoint;
           TokenCount = tokenCount;
           PTokens = pTokens;
           StreamCount = streamCount;
           PStreamStrides = pStreamStrides;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public IndirectCommandsLayoutUsageFlagsNV Flags;
/// <summary></summary>
        public PipelineBindPoint PipelineBindPoint;
/// <summary></summary>
        public uint TokenCount;
/// <summary></summary>
        public IndirectCommandsLayoutTokenNV* PTokens;
/// <summary></summary>
        public uint StreamCount;
/// <summary></summary>
        public uint* PStreamStrides;
    }
}
