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
    [NativeName("Name", "VkImportFenceWin32HandleInfoKHR")]
    public unsafe partial struct ImportFenceWin32HandleInfoKHR : IChainable
    {
        public ImportFenceWin32HandleInfoKHR
        (
            StructureType? sType = StructureType.ImportFenceWin32HandleInfoKhr,
            void* pNext = null,
            Fence? fence = null,
            FenceImportFlags? flags = null,
            ExternalFenceHandleTypeFlags? handleType = null,
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

            if (fence is not null)
            {
                Fence = fence.Value;
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
        [NativeName("Type", "VkFence")]
        [NativeName("Type.Name", "VkFence")]
        [NativeName("Name", "fence")]
        public Fence Fence;
/// <summary></summary>
        [NativeName("Type", "VkFenceImportFlags")]
        [NativeName("Type.Name", "VkFenceImportFlags")]
        [NativeName("Name", "flags")]
        public FenceImportFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkExternalFenceHandleTypeFlagBits")]
        [NativeName("Type.Name", "VkExternalFenceHandleTypeFlagBits")]
        [NativeName("Name", "handleType")]
        public ExternalFenceHandleTypeFlags HandleType;
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
            return SType = StructureType.ImportFenceWin32HandleInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
