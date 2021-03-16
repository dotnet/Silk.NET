// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
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
