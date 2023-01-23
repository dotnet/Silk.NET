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
    [NativeName("Name", "VkIndirectCommandsLayoutCreateInfoNV")]
    public unsafe partial struct IndirectCommandsLayoutCreateInfoNV : IChainable
    {
        public IndirectCommandsLayoutCreateInfoNV
        (
            StructureType? sType = StructureType.IndirectCommandsLayoutCreateInfoNV,
            void* pNext = null,
            IndirectCommandsLayoutUsageFlagsNV? flags = null,
            PipelineBindPoint? pipelineBindPoint = null,
            uint? tokenCount = null,
            IndirectCommandsLayoutTokenNV* pTokens = null,
            uint? streamCount = null,
            uint* pStreamStrides = null
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

            if (pipelineBindPoint is not null)
            {
                PipelineBindPoint = pipelineBindPoint.Value;
            }

            if (tokenCount is not null)
            {
                TokenCount = tokenCount.Value;
            }

            if (pTokens is not null)
            {
                PTokens = pTokens;
            }

            if (streamCount is not null)
            {
                StreamCount = streamCount.Value;
            }

            if (pStreamStrides is not null)
            {
                PStreamStrides = pStreamStrides;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.IndirectCommandsLayoutCreateInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
