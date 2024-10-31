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
    [NativeName("Name", "VkCommandPoolMemoryConsumption")]
    public unsafe partial struct CommandPoolMemoryConsumption : IChainable
    {
        public CommandPoolMemoryConsumption
        (
            StructureType? sType = StructureType.CommandPoolMemoryConsumption,
            void* pNext = null,
            ulong? commandPoolAllocated = null,
            ulong? commandPoolReservedSize = null,
            ulong? commandBufferAllocated = null
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

            if (commandPoolAllocated is not null)
            {
                CommandPoolAllocated = commandPoolAllocated.Value;
            }

            if (commandPoolReservedSize is not null)
            {
                CommandPoolReservedSize = commandPoolReservedSize.Value;
            }

            if (commandBufferAllocated is not null)
            {
                CommandBufferAllocated = commandBufferAllocated.Value;
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
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "commandPoolAllocated")]
        public ulong CommandPoolAllocated;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "commandPoolReservedSize")]
        public ulong CommandPoolReservedSize;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "commandBufferAllocated")]
        public ulong CommandBufferAllocated;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CommandPoolMemoryConsumption;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
