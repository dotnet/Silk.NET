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
    [NativeName("Name", "VkCommandBufferAllocateInfo")]
    public unsafe partial struct CommandBufferAllocateInfo : IChainable
    {
        public CommandBufferAllocateInfo
        (
            StructureType? sType = StructureType.CommandBufferAllocateInfo,
            void* pNext = null,
            CommandPool? commandPool = null,
            CommandBufferLevel? level = null,
            uint? commandBufferCount = null
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

            if (commandPool is not null)
            {
                CommandPool = commandPool.Value;
            }

            if (level is not null)
            {
                Level = level.Value;
            }

            if (commandBufferCount is not null)
            {
                CommandBufferCount = commandBufferCount.Value;
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
        [NativeName("Type", "VkCommandPool")]
        [NativeName("Type.Name", "VkCommandPool")]
        [NativeName("Name", "commandPool")]
        public CommandPool CommandPool;
/// <summary></summary>
        [NativeName("Type", "VkCommandBufferLevel")]
        [NativeName("Type.Name", "VkCommandBufferLevel")]
        [NativeName("Name", "level")]
        public CommandBufferLevel Level;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "commandBufferCount")]
        public uint CommandBufferCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CommandBufferAllocateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
