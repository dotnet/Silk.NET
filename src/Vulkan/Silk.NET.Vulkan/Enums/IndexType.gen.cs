// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkIndexType")]
    public enum IndexType
    {
        [NativeName("Name", "VK_INDEX_TYPE_UINT16")]
        Uint16 = 0,
        [NativeName("Name", "VK_INDEX_TYPE_UINT32")]
        Uint32 = 1,
        [NativeName("Name", "VK_INDEX_TYPE_NONE_KHR")]
        NoneKhr = 1000165000,
        [NativeName("Name", "VK_INDEX_TYPE_NONE_NV")]
        NoneNV = 1000165000,
        [NativeName("Name", "VK_INDEX_TYPE_UINT8_EXT")]
        Uint8Ext = 1000265000,
    }
}
