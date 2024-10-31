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
    [NativeName("Name", "VkVideoSessionMemoryRequirementsKHR")]
    public unsafe partial struct VideoSessionMemoryRequirementsKHR : IChainable
    {
        public VideoSessionMemoryRequirementsKHR
        (
            StructureType? sType = StructureType.VideoSessionMemoryRequirementsKhr,
            void* pNext = null,
            uint? memoryBindIndex = null,
            MemoryRequirements? memoryRequirements = null
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

            if (memoryBindIndex is not null)
            {
                MemoryBindIndex = memoryBindIndex.Value;
            }

            if (memoryRequirements is not null)
            {
                MemoryRequirements = memoryRequirements.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryBindIndex")]
        public uint MemoryBindIndex;
/// <summary></summary>
        [NativeName("Type", "VkMemoryRequirements")]
        [NativeName("Type.Name", "VkMemoryRequirements")]
        [NativeName("Name", "memoryRequirements")]
        public MemoryRequirements MemoryRequirements;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoSessionMemoryRequirementsKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
