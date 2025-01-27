// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkIndexType")]
    public enum IndexType : int
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
        [NativeName("Name", "VK_INDEX_TYPE_UINT8_KHR")]
        Uint8Khr = 1000265000,
    }
}
