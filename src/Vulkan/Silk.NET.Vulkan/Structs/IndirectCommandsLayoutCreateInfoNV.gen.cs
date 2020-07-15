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
    [NativeName("Name", "VkIndirectCommandsLayoutCreateInfoNV")]
    public unsafe partial struct IndirectCommandsLayoutCreateInfoNV
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
        [NativeName("Type", "VkIndirectCommandsLayoutUsageFlagsNV")]
        [NativeName("Type.Name", "VkIndirectCommandsLayoutUsageFlagsNV")]
        [NativeName("Name", "flags")]
        public IndirectCommandsLayoutUsageFlagsNV Flags;
/// <summary></summary>
        [NativeName("Type", "VkPipelineBindPoint")]
        [NativeName("Type.Name", "VkPipelineBindPoint")]
        [NativeName("Name", "pipelineBindPoint")]
        public PipelineBindPoint PipelineBindPoint;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "tokenCount")]
        public uint TokenCount;
/// <summary></summary>
        [NativeName("Type", "VkIndirectCommandsLayoutTokenNV*")]
        [NativeName("Type.Name", "VkIndirectCommandsLayoutTokenNV")]
        [NativeName("Name", "pTokens")]
        public IndirectCommandsLayoutTokenNV* PTokens;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "streamCount")]
        public uint StreamCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pStreamStrides")]
        public uint* PStreamStrides;
    }
}
