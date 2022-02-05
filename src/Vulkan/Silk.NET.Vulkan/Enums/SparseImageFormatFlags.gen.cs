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
        [NativeName("Name", "VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT")]
        SparseImageFormatSingleMiptailBit = 1,
        [NativeName("Name", "VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT")]
        SparseImageFormatAlignedMipSizeBit = 2,
        [NativeName("Name", "VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT")]
        SparseImageFormatNonstandardBlockSizeBit = 4,
    }
}
