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
    [NativeName("Name", "VkImportSemaphoreWin32HandleInfoKHR")]
    public unsafe partial struct ImportSemaphoreWin32HandleInfoKHR : IChainable
    {
        public ImportSemaphoreWin32HandleInfoKHR
        (
            StructureType? sType = StructureType.ImportSemaphoreWin32HandleInfoKhr,
            void* pNext = null,
            Semaphore? semaphore = null,
            SemaphoreImportFlags? flags = null,
            ExternalSemaphoreHandleTypeFlags? handleType = null,
            nint? handle = null,
            nint? name = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (handleType is not null)
            {
                HandleType = handleType.Value;
            }

            if (handle is not null)
            {
                Handle = handle.Value;
            }

            if (name is not null)
            {
                Name = name.Value;
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
        [NativeName("Type", "VkSemaphoreImportFlags")]
        [NativeName("Type.Name", "VkSemaphoreImportFlags")]
        [NativeName("Name", "flags")]
        public SemaphoreImportFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkExternalSemaphoreHandleTypeFlagBits")]
        [NativeName("Type.Name", "VkExternalSemaphoreHandleTypeFlagBits")]
        [NativeName("Name", "handleType")]
        public ExternalSemaphoreHandleTypeFlags HandleType;
/// <summary></summary>
        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "handle")]
        public nint Handle;
/// <summary></summary>
        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "name")]
        public nint Name;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImportSemaphoreWin32HandleInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
