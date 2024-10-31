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
    [NativeName("Name", "VkCommandBufferSubmitInfo")]
    [NativeName("Aliases", "VkCommandBufferSubmitInfoKHR")]
    public unsafe partial struct CommandBufferSubmitInfo : IChainStart
    {
        public CommandBufferSubmitInfo
        (
            StructureType? sType = StructureType.CommandBufferSubmitInfo,
            void* pNext = null,
            CommandBuffer? commandBuffer = null,
            uint? deviceMask = null
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

            if (commandBuffer is not null)
            {
                CommandBuffer = commandBuffer.Value;
            }

            if (deviceMask is not null)
            {
                DeviceMask = deviceMask.Value;
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
        [NativeName("Type", "VkCommandBuffer")]
        [NativeName("Type.Name", "VkCommandBuffer")]
        [NativeName("Name", "commandBuffer")]
        public CommandBuffer CommandBuffer;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceMask")]
        public uint DeviceMask;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CommandBufferSubmitInfo;
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
        public static unsafe ref CommandBufferSubmitInfo Chain(
            out CommandBufferSubmitInfo capture)
        {
            capture = new CommandBufferSubmitInfo(StructureType.CommandBufferSubmitInfo);
            return ref capture;
        }
    }
}
