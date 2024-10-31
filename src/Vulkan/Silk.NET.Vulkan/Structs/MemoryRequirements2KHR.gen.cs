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
    [NativeName("Name", "VkMemoryRequirements2KHR")]
    [NativeName("AliasOf", "VkMemoryRequirements2")]
    public unsafe partial struct MemoryRequirements2KHR : IChainStart
    {
        public MemoryRequirements2KHR
        (
            StructureType? sType = StructureType.MemoryRequirements2,
            void* pNext = null,
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
        [NativeName("Type", "VkMemoryRequirements")]
        [NativeName("Type.Name", "VkMemoryRequirements")]
        [NativeName("Name", "memoryRequirements")]
        public MemoryRequirements MemoryRequirements;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.MemoryRequirements2;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref MemoryRequirements2KHR Chain(
            out MemoryRequirements2KHR capture)
        {
            capture = new MemoryRequirements2KHR(StructureType.MemoryRequirements2);
            return ref capture;
        }
    }
}
