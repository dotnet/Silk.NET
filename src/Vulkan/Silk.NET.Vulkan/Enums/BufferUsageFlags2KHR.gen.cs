// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkBufferUsageFlags2KHR")]
    public enum BufferUsageFlags2KHR : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"TransferSrcBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT")]
        BufferUsage2TransferSrcBit = 1,
        [Obsolete("Deprecated in favour of \"TransferDstBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_DST_BIT")]
        BufferUsage2TransferDstBit = 2,
        [Obsolete("Deprecated in favour of \"UniformTexelBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT")]
        BufferUsage2UniformTexelBufferBit = 4,
        [Obsolete("Deprecated in favour of \"StorageTexelBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT")]
        BufferUsage2StorageTexelBufferBit = 8,
        [Obsolete("Deprecated in favour of \"UniformBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT")]
        BufferUsage2UniformBufferBit = 16,
        [Obsolete("Deprecated in favour of \"StorageBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT")]
        BufferUsage2StorageBufferBit = 32,
        [Obsolete("Deprecated in favour of \"IndexBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT")]
        BufferUsage2IndexBufferBit = 64,
        [Obsolete("Deprecated in favour of \"VertexBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT")]
        BufferUsage2VertexBufferBit = 128,
        [Obsolete("Deprecated in favour of \"IndirectBufferBit\"")]
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT")]
        BufferUsage2IndirectBufferBit = 256,
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT")]
        TransferSrcBit = 1,
        [NativeName("Name", "VK_BUFFER_USAGE_2_TRANSFER_DST_BIT")]
        TransferDstBit = 2,
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT")]
        UniformTexelBufferBit = 4,
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT")]
        StorageTexelBufferBit = 8,
        [NativeName("Name", "VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT")]
        UniformBufferBit = 16,
        [NativeName("Name", "VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT")]
        StorageBufferBit = 32,
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT")]
        IndexBufferBit = 64,
        [NativeName("Name", "VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT")]
        VertexBufferBit = 128,
        [NativeName("Name", "VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT")]
        IndirectBufferBit = 256,
    }
}
