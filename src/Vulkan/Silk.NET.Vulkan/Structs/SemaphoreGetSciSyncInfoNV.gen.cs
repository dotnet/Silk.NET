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
    [NativeName("Name", "VkSemaphoreGetSciSyncInfoNV")]
    public unsafe partial struct SemaphoreGetSciSyncInfoNV : IChainable
    {
        public SemaphoreGetSciSyncInfoNV
        (
            StructureType? sType = StructureType.SemaphoreGetSciSyncInfoNV,
            void* pNext = null,
            Semaphore? semaphore = null,
            ExternalSemaphoreHandleTypeFlags? handleType = null
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

            if (semaphore is not null)
            {
                Semaphore = semaphore.Value;
            }

            if (handleType is not null)
            {
                HandleType = handleType.Value;
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
        [NativeName("Type", "VkSemaphore")]
        [NativeName("Type.Name", "VkSemaphore")]
        [NativeName("Name", "semaphore")]
        public Semaphore Semaphore;
/// <summary></summary>
        [NativeName("Type", "VkExternalSemaphoreHandleTypeFlagBits")]
        [NativeName("Type.Name", "VkExternalSemaphoreHandleTypeFlagBits")]
        [NativeName("Name", "handleType")]
        public ExternalSemaphoreHandleTypeFlags HandleType;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SemaphoreGetSciSyncInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
