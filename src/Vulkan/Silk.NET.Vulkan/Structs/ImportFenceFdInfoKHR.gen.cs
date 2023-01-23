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
    [NativeName("Name", "VkImportFenceFdInfoKHR")]
    public unsafe partial struct ImportFenceFdInfoKHR : IChainable
    {
        public ImportFenceFdInfoKHR
        (
            StructureType? sType = StructureType.ImportFenceFDInfoKhr,
            void* pNext = null,
            Fence? fence = null,
            FenceImportFlags? flags = null,
            ExternalFenceHandleTypeFlags? handleType = null,
            int? fd = null
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

            if (fd is not null)
            {
                Fd = fd.Value;
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
        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "fd")]
        public int Fd;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImportFenceFDInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
