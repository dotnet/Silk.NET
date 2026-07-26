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
    [NativeName("Name", "VkCopyMemoryToImageIndirectInfoKHR")]
    public unsafe partial struct CopyMemoryToImageIndirectInfoKHR : IChainable
    {
        public CopyMemoryToImageIndirectInfoKHR
        (
            StructureType? sType = StructureType.CopyMemoryToImageIndirectInfoKhr,
            void* pNext = null,
            AddressCopyFlagsKHR? srcCopyFlags = null,
            uint? copyCount = null,
            StridedDeviceAddressRangeKHR? copyAddressRange = null,
            Image? dstImage = null,
            ImageLayout? dstImageLayout = null,
            ImageSubresourceLayers* pImageSubresources = null
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

            if (copyCount is not null)
            {
                CopyCount = copyCount.Value;
            }

            if (copyAddressRange is not null)
            {
                CopyAddressRange = copyAddressRange.Value;
            }

            if (dstImage is not null)
            {
                DstImage = dstImage.Value;
            }

            if (dstImageLayout is not null)
            {
                DstImageLayout = dstImageLayout.Value;
            }

            if (pImageSubresources is not null)
            {
                PImageSubresources = pImageSubresources;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "copyCount")]
        public uint CopyCount;
/// <summary></summary>
        [NativeName("Type", "VkStridedDeviceAddressRangeKHR")]
        [NativeName("Type.Name", "VkStridedDeviceAddressRangeKHR")]
        [NativeName("Name", "copyAddressRange")]
        public StridedDeviceAddressRangeKHR CopyAddressRange;
/// <summary></summary>
        [NativeName("Type", "VkImage")]
        [NativeName("Type.Name", "VkImage")]
        [NativeName("Name", "dstImage")]
        public Image DstImage;
/// <summary></summary>
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "dstImageLayout")]
        public ImageLayout DstImageLayout;
/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceLayers*")]
        [NativeName("Type.Name", "VkImageSubresourceLayers")]
        [NativeName("Name", "pImageSubresources")]
        public ImageSubresourceLayers* PImageSubresources;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CopyMemoryToImageIndirectInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
