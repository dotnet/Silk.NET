// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSparseImageFormatFlags")]
    public enum SparseImageFormatFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SingleMiptailBit\"")]
        [NativeName("Name", "VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT")]
        SparseImageFormatSingleMiptailBit = 1,
        [Obsolete("Deprecated in favour of \"AlignedMipSizeBit\"")]
        [NativeName("Name", "VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT")]
        SparseImageFormatAlignedMipSizeBit = 2,
        [Obsolete("Deprecated in favour of \"NonstandardBlockSizeBit\"")]
        [NativeName("Name", "VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT")]
        SparseImageFormatNonstandardBlockSizeBit = 4,
        [NativeName("Name", "VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT")]
        SingleMiptailBit = 1,
        [NativeName("Name", "VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT")]
        AlignedMipSizeBit = 2,
        [NativeName("Name", "VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT")]
        NonstandardBlockSizeBit = 4,
    }
}
