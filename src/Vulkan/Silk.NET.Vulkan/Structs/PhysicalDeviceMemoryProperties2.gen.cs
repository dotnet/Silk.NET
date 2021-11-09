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
    [NativeName("Name", "VkPhysicalDeviceMemoryProperties2")]
    [NativeName("Aliases", "VkPhysicalDeviceMemoryProperties2KHR")]
    public unsafe partial struct PhysicalDeviceMemoryProperties2 : IChainStart
    {
        public PhysicalDeviceMemoryProperties2
        (
            StructureType? sType = StructureType.PhysicalDeviceMemoryProperties2,
            void* pNext = null,
            PhysicalDeviceMemoryProperties? memoryProperties = null
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

            if (memoryProperties is not null)
            {
                MemoryProperties = memoryProperties.Value;
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
        [NativeName("Type", "VkPhysicalDeviceMemoryProperties")]
        [NativeName("Type.Name", "VkPhysicalDeviceMemoryProperties")]
        [NativeName("Name", "memoryProperties")]
        public PhysicalDeviceMemoryProperties MemoryProperties;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceMemoryProperties2;
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
        public static unsafe ref PhysicalDeviceMemoryProperties2 Chain(
            out PhysicalDeviceMemoryProperties2 capture)
        {
            capture = new PhysicalDeviceMemoryProperties2(StructureType.PhysicalDeviceMemoryProperties2);
            return ref capture;
        }
    }
}
