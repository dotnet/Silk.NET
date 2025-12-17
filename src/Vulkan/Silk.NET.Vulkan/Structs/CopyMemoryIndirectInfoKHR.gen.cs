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
    [NativeName("Name", "VkCopyMemoryIndirectInfoKHR")]
    public unsafe partial struct CopyMemoryIndirectInfoKHR : IChainable
    {
        public CopyMemoryIndirectInfoKHR
        (
            StructureType? sType = StructureType.CopyMemoryIndirectInfoKhr,
            void* pNext = null,
            AddressCopyFlagsKHR? srcCopyFlags = null,
            AddressCopyFlagsKHR? dstCopyFlags = null,
            uint? copyCount = null,
            StridedDeviceAddressRangeKHR? copyAddressRange = null
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

            if (srcCopyFlags is not null)
            {
                SrcCopyFlags = srcCopyFlags.Value;
            }

            if (dstCopyFlags is not null)
            {
                DstCopyFlags = dstCopyFlags.Value;
            }

            if (copyCount is not null)
            {
                CopyCount = copyCount.Value;
            }

            if (copyAddressRange is not null)
            {
                CopyAddressRange = copyAddressRange.Value;
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
        [NativeName("Type", "VkAddressCopyFlagsKHR")]
        [NativeName("Type.Name", "VkAddressCopyFlagsKHR")]
        [NativeName("Name", "srcCopyFlags")]
        public AddressCopyFlagsKHR SrcCopyFlags;
/// <summary></summary>
        [NativeName("Type", "VkAddressCopyFlagsKHR")]
        [NativeName("Type.Name", "VkAddressCopyFlagsKHR")]
        [NativeName("Name", "dstCopyFlags")]
        public AddressCopyFlagsKHR DstCopyFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "copyCount")]
        public uint CopyCount;
/// <summary></summary>
        [NativeName("Type", "VkStridedDeviceAddressRangeKHR")]
        [NativeName("Type.Name", "VkStridedDeviceAddressRangeKHR")]
        [NativeName("Name", "copyAddressRange")]
        public StridedDeviceAddressRangeKHR CopyAddressRange;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CopyMemoryIndirectInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
