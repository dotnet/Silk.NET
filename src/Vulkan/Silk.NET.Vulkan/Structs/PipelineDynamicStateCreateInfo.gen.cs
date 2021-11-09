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
    [NativeName("Name", "VkPipelineDynamicStateCreateInfo")]
    public unsafe partial struct PipelineDynamicStateCreateInfo : IChainable
    {
        public PipelineDynamicStateCreateInfo
        (
            StructureType? sType = StructureType.PipelineDynamicStateCreateInfo,
            void* pNext = null,
            uint? flags = null,
            uint? dynamicStateCount = null,
            DynamicState* pDynamicStates = null
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

            if (dynamicStateCount is not null)
            {
                DynamicStateCount = dynamicStateCount.Value;
            }

            if (pDynamicStates is not null)
            {
                PDynamicStates = pDynamicStates;
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
        [NativeName("Type", "VkPipelineDynamicStateCreateFlags")]
        [NativeName("Type.Name", "VkPipelineDynamicStateCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dynamicStateCount")]
        public uint DynamicStateCount;
/// <summary></summary>
        [NativeName("Type", "VkDynamicState*")]
        [NativeName("Type.Name", "VkDynamicState")]
        [NativeName("Name", "pDynamicStates")]
        public DynamicState* PDynamicStates;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PipelineDynamicStateCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
