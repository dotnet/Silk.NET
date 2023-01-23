// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAccessFlags2KHR")]
    public enum AccessFlags2KHR : long
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "VK_ACCESS_2_NONE")]
        Access2None = 0,
        [Obsolete("Deprecated in favour of \"NoneKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_NONE_KHR")]
        Access2NoneKhr = 0,
        [Obsolete("Deprecated in favour of \"IndirectCommandReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT")]
        Access2IndirectCommandReadBit = 1,
        [Obsolete("Deprecated in favour of \"IndirectCommandReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR")]
        Access2IndirectCommandReadBitKhr = 1,
        [Obsolete("Deprecated in favour of \"IndexReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_INDEX_READ_BIT")]
        Access2IndexReadBit = 2,
        [Obsolete("Deprecated in favour of \"IndexReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_INDEX_READ_BIT_KHR")]
        Access2IndexReadBitKhr = 2,
        [Obsolete("Deprecated in favour of \"VertexAttributeReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT")]
        Access2VertexAttributeReadBit = 4,
        [Obsolete("Deprecated in favour of \"VertexAttributeReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR")]
        Access2VertexAttributeReadBitKhr = 4,
        [Obsolete("Deprecated in favour of \"UniformReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_UNIFORM_READ_BIT")]
        Access2UniformReadBit = 8,
        [Obsolete("Deprecated in favour of \"UniformReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_UNIFORM_READ_BIT_KHR")]
        Access2UniformReadBitKhr = 8,
        [Obsolete("Deprecated in favour of \"InputAttachmentReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT")]
        Access2InputAttachmentReadBit = 16,
        [Obsolete("Deprecated in favour of \"InputAttachmentReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR")]
        Access2InputAttachmentReadBitKhr = 16,
        [Obsolete("Deprecated in favour of \"ShaderReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_READ_BIT")]
        Access2ShaderReadBit = 32,
        [Obsolete("Deprecated in favour of \"ShaderReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_READ_BIT_KHR")]
        Access2ShaderReadBitKhr = 32,
        [Obsolete("Deprecated in favour of \"ShaderWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_WRITE_BIT")]
        Access2ShaderWriteBit = 64,
        [Obsolete("Deprecated in favour of \"ShaderWriteBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_WRITE_BIT_KHR")]
        Access2ShaderWriteBitKhr = 64,
        [Obsolete("Deprecated in favour of \"ColorAttachmentReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT")]
        Access2ColorAttachmentReadBit = 128,
        [Obsolete("Deprecated in favour of \"ColorAttachmentReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR")]
        Access2ColorAttachmentReadBitKhr = 128,
        [Obsolete("Deprecated in favour of \"ColorAttachmentWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT")]
        Access2ColorAttachmentWriteBit = 256,
        [Obsolete("Deprecated in favour of \"ColorAttachmentWriteBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR")]
        Access2ColorAttachmentWriteBitKhr = 256,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT")]
        Access2DepthStencilAttachmentReadBit = 512,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR")]
        Access2DepthStencilAttachmentReadBitKhr = 512,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT")]
        Access2DepthStencilAttachmentWriteBit = 1024,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentWriteBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR")]
        Access2DepthStencilAttachmentWriteBitKhr = 1024,
        [Obsolete("Deprecated in favour of \"TransferReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_READ_BIT")]
        Access2TransferReadBit = 2048,
        [Obsolete("Deprecated in favour of \"TransferReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_READ_BIT_KHR")]
        Access2TransferReadBitKhr = 2048,
        [Obsolete("Deprecated in favour of \"TransferWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_WRITE_BIT")]
        Access2TransferWriteBit = 4096,
        [Obsolete("Deprecated in favour of \"TransferWriteBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR")]
        Access2TransferWriteBitKhr = 4096,
        [Obsolete("Deprecated in favour of \"HostReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_HOST_READ_BIT")]
        Access2HostReadBit = 8192,
        [Obsolete("Deprecated in favour of \"HostReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_HOST_READ_BIT_KHR")]
        Access2HostReadBitKhr = 8192,
        [Obsolete("Deprecated in favour of \"HostWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_HOST_WRITE_BIT")]
        Access2HostWriteBit = 16384,
        [Obsolete("Deprecated in favour of \"HostWriteBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_HOST_WRITE_BIT_KHR")]
        Access2HostWriteBitKhr = 16384,
        [Obsolete("Deprecated in favour of \"MemoryReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_MEMORY_READ_BIT")]
        Access2MemoryReadBit = 32768,
        [Obsolete("Deprecated in favour of \"MemoryReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_MEMORY_READ_BIT_KHR")]
        Access2MemoryReadBitKhr = 32768,
        [Obsolete("Deprecated in favour of \"MemoryWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_MEMORY_WRITE_BIT")]
        Access2MemoryWriteBit = 65536,
        [Obsolete("Deprecated in favour of \"MemoryWriteBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_MEMORY_WRITE_BIT_KHR")]
        Access2MemoryWriteBitKhr = 65536,
        [Obsolete("Deprecated in favour of \"ShaderSampledReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_SAMPLED_READ_BIT")]
        Access2ShaderSampledReadBit = 4294967296,
        [Obsolete("Deprecated in favour of \"ShaderSampledReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR")]
        Access2ShaderSampledReadBitKhr = 4294967296,
        [Obsolete("Deprecated in favour of \"ShaderStorageReadBit\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_READ_BIT")]
        Access2ShaderStorageReadBit = 8589934592,
        [Obsolete("Deprecated in favour of \"ShaderStorageReadBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR")]
        Access2ShaderStorageReadBitKhr = 8589934592,
        [Obsolete("Deprecated in favour of \"ShaderStorageWriteBit\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT")]
        Access2ShaderStorageWriteBit = 17179869184,
        [Obsolete("Deprecated in favour of \"ShaderStorageWriteBitKhr\"")]
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR")]
        Access2ShaderStorageWriteBitKhr = 17179869184,
        [NativeName("Name", "VK_ACCESS_2_NONE")]
        None = 0,
        [NativeName("Name", "VK_ACCESS_2_NONE_KHR")]
        NoneKhr = 0,
        [NativeName("Name", "VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT")]
        IndirectCommandReadBit = 1,
        [NativeName("Name", "VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR")]
        IndirectCommandReadBitKhr = 1,
        [NativeName("Name", "VK_ACCESS_2_INDEX_READ_BIT")]
        IndexReadBit = 2,
        [NativeName("Name", "VK_ACCESS_2_INDEX_READ_BIT_KHR")]
        IndexReadBitKhr = 2,
        [NativeName("Name", "VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT")]
        VertexAttributeReadBit = 4,
        [NativeName("Name", "VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR")]
        VertexAttributeReadBitKhr = 4,
        [NativeName("Name", "VK_ACCESS_2_UNIFORM_READ_BIT")]
        UniformReadBit = 8,
        [NativeName("Name", "VK_ACCESS_2_UNIFORM_READ_BIT_KHR")]
        UniformReadBitKhr = 8,
        [NativeName("Name", "VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT")]
        InputAttachmentReadBit = 16,
        [NativeName("Name", "VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR")]
        InputAttachmentReadBitKhr = 16,
        [NativeName("Name", "VK_ACCESS_2_SHADER_READ_BIT")]
        ShaderReadBit = 32,
        [NativeName("Name", "VK_ACCESS_2_SHADER_READ_BIT_KHR")]
        ShaderReadBitKhr = 32,
        [NativeName("Name", "VK_ACCESS_2_SHADER_WRITE_BIT")]
        ShaderWriteBit = 64,
        [NativeName("Name", "VK_ACCESS_2_SHADER_WRITE_BIT_KHR")]
        ShaderWriteBitKhr = 64,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT")]
        ColorAttachmentReadBit = 128,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR")]
        ColorAttachmentReadBitKhr = 128,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT")]
        ColorAttachmentWriteBit = 256,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR")]
        ColorAttachmentWriteBitKhr = 256,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT")]
        DepthStencilAttachmentReadBit = 512,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR")]
        DepthStencilAttachmentReadBitKhr = 512,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT")]
        DepthStencilAttachmentWriteBit = 1024,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR")]
        DepthStencilAttachmentWriteBitKhr = 1024,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_READ_BIT")]
        TransferReadBit = 2048,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_READ_BIT_KHR")]
        TransferReadBitKhr = 2048,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_WRITE_BIT")]
        TransferWriteBit = 4096,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR")]
        TransferWriteBitKhr = 4096,
        [NativeName("Name", "VK_ACCESS_2_HOST_READ_BIT")]
        HostReadBit = 8192,
        [NativeName("Name", "VK_ACCESS_2_HOST_READ_BIT_KHR")]
        HostReadBitKhr = 8192,
        [NativeName("Name", "VK_ACCESS_2_HOST_WRITE_BIT")]
        HostWriteBit = 16384,
        [NativeName("Name", "VK_ACCESS_2_HOST_WRITE_BIT_KHR")]
        HostWriteBitKhr = 16384,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_READ_BIT")]
        MemoryReadBit = 32768,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_READ_BIT_KHR")]
        MemoryReadBitKhr = 32768,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_WRITE_BIT")]
        MemoryWriteBit = 65536,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_WRITE_BIT_KHR")]
        MemoryWriteBitKhr = 65536,
        [NativeName("Name", "VK_ACCESS_2_SHADER_SAMPLED_READ_BIT")]
        ShaderSampledReadBit = 4294967296,
        [NativeName("Name", "VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR")]
        ShaderSampledReadBitKhr = 4294967296,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_READ_BIT")]
        ShaderStorageReadBit = 8589934592,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR")]
        ShaderStorageReadBitKhr = 8589934592,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT")]
        ShaderStorageWriteBit = 17179869184,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR")]
        ShaderStorageWriteBitKhr = 17179869184,
    }
}
