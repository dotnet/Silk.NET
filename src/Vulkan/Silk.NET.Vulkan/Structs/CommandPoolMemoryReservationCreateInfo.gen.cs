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
    [NativeName("Name", "VkCommandPoolMemoryReservationCreateInfo")]
    public unsafe partial struct CommandPoolMemoryReservationCreateInfo : IExtendsChain<CommandPoolCreateInfo>
    {
        public CommandPoolMemoryReservationCreateInfo
        (
            StructureType? sType = StructureType.CommandPoolMemoryReservationCreateInfo,
            void* pNext = null,
            ulong? commandPoolReservedSize = null,
            uint? commandPoolMaxCommandBuffers = null
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

            if (commandPoolReservedSize is not null)
            {
                CommandPoolReservedSize = commandPoolReservedSize.Value;
            }

            if (commandPoolMaxCommandBuffers is not null)
            {
                CommandPoolMaxCommandBuffers = commandPoolMaxCommandBuffers.Value;
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
        [NativeName("Name", "commandPoolReservedSize")]
        public ulong CommandPoolReservedSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "commandPoolMaxCommandBuffers")]
        public uint CommandPoolMaxCommandBuffers;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CommandPoolMemoryReservationCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
