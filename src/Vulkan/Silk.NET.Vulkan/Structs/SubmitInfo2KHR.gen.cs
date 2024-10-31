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
    [NativeName("Name", "VkSubmitInfo2KHR")]
    [NativeName("AliasOf", "VkSubmitInfo2")]
    public unsafe partial struct SubmitInfo2KHR : IChainStart
    {
        public SubmitInfo2KHR
        (
            StructureType? sType = StructureType.SubmitInfo2,
            void* pNext = null,
            SubmitFlags? flags = null,
            uint? waitSemaphoreInfoCount = null,
            SemaphoreSubmitInfo* pWaitSemaphoreInfos = null,
            uint? commandBufferInfoCount = null,
            CommandBufferSubmitInfo* pCommandBufferInfos = null,
            uint? signalSemaphoreInfoCount = null,
            SemaphoreSubmitInfo* pSignalSemaphoreInfos = null
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

            if (waitSemaphoreInfoCount is not null)
            {
                WaitSemaphoreInfoCount = waitSemaphoreInfoCount.Value;
            }

            if (pWaitSemaphoreInfos is not null)
            {
                PWaitSemaphoreInfos = pWaitSemaphoreInfos;
            }

            if (commandBufferInfoCount is not null)
            {
                CommandBufferInfoCount = commandBufferInfoCount.Value;
            }

            if (pCommandBufferInfos is not null)
            {
                PCommandBufferInfos = pCommandBufferInfos;
            }

            if (signalSemaphoreInfoCount is not null)
            {
                SignalSemaphoreInfoCount = signalSemaphoreInfoCount.Value;
            }

            if (pSignalSemaphoreInfos is not null)
            {
                PSignalSemaphoreInfos = pSignalSemaphoreInfos;
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
        [NativeName("Type", "VkSubmitFlags")]
        [NativeName("Type.Name", "VkSubmitFlags")]
        [NativeName("Name", "flags")]
        public SubmitFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "waitSemaphoreInfoCount")]
        public uint WaitSemaphoreInfoCount;
/// <summary></summary>
        [NativeName("Type", "VkSemaphoreSubmitInfo*")]
        [NativeName("Type.Name", "VkSemaphoreSubmitInfo")]
        [NativeName("Name", "pWaitSemaphoreInfos")]
        public SemaphoreSubmitInfo* PWaitSemaphoreInfos;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "commandBufferInfoCount")]
        public uint CommandBufferInfoCount;
/// <summary></summary>
        [NativeName("Type", "VkCommandBufferSubmitInfo*")]
        [NativeName("Type.Name", "VkCommandBufferSubmitInfo")]
        [NativeName("Name", "pCommandBufferInfos")]
        public CommandBufferSubmitInfo* PCommandBufferInfos;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "signalSemaphoreInfoCount")]
        public uint SignalSemaphoreInfoCount;
/// <summary></summary>
        [NativeName("Type", "VkSemaphoreSubmitInfo*")]
        [NativeName("Type.Name", "VkSemaphoreSubmitInfo")]
        [NativeName("Name", "pSignalSemaphoreInfos")]
        public SemaphoreSubmitInfo* PSignalSemaphoreInfos;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SubmitInfo2;
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
        public static unsafe ref SubmitInfo2KHR Chain(
            out SubmitInfo2KHR capture)
        {
            capture = new SubmitInfo2KHR(StructureType.SubmitInfo2);
            return ref capture;
        }
    }
}
