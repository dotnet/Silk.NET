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
    [NativeName("Name", "VkSemaphoreWaitInfoKHR")]
    [NativeName("AliasOf", "VkSemaphoreWaitInfo")]
    public unsafe partial struct SemaphoreWaitInfoKHR : IChainable
    {
        public SemaphoreWaitInfoKHR
        (
            StructureType? sType = StructureType.SemaphoreWaitInfo,
            void* pNext = null,
            SemaphoreWaitFlags? flags = null,
            uint? semaphoreCount = null,
            Semaphore* pSemaphores = null,
            ulong* pValues = null
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

            if (semaphoreCount is not null)
            {
                SemaphoreCount = semaphoreCount.Value;
            }

            if (pSemaphores is not null)
            {
                PSemaphores = pSemaphores;
            }

            if (pValues is not null)
            {
                PValues = pValues;
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
        [NativeName("Type", "VkSemaphoreWaitFlags")]
        [NativeName("Type.Name", "VkSemaphoreWaitFlags")]
        [NativeName("Name", "flags")]
        public SemaphoreWaitFlags Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "semaphoreCount")]
        public uint SemaphoreCount;
/// <summary></summary>
        [NativeName("Type", "VkSemaphore*")]
        [NativeName("Type.Name", "VkSemaphore")]
        [NativeName("Name", "pSemaphores")]
        public Semaphore* PSemaphores;
/// <summary></summary>
        [NativeName("Type", "uint64_t*")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pValues")]
        public ulong* PValues;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SemaphoreWaitInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
