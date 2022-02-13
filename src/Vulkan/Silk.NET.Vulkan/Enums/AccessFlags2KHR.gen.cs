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
        [NativeName("Name", "VK_ACCESS_2_NONE")]
        Access2None = 0,
        [NativeName("Name", "VK_ACCESS_2_NONE_KHR")]
        Access2NoneKhr = 0,
        [NativeName("Name", "VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT")]
        Access2IndirectCommandReadBit = 1,
        [NativeName("Name", "VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR")]
        Access2IndirectCommandReadBitKhr = 1,
        [NativeName("Name", "VK_ACCESS_2_INDEX_READ_BIT")]
        Access2IndexReadBit = 2,
        [NativeName("Name", "VK_ACCESS_2_INDEX_READ_BIT_KHR")]
        Access2IndexReadBitKhr = 2,
        [NativeName("Name", "VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT")]
        Access2VertexAttributeReadBit = 4,
        [NativeName("Name", "VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR")]
        Access2VertexAttributeReadBitKhr = 4,
        [NativeName("Name", "VK_ACCESS_2_UNIFORM_READ_BIT")]
        Access2UniformReadBit = 8,
        [NativeName("Name", "VK_ACCESS_2_UNIFORM_READ_BIT_KHR")]
        Access2UniformReadBitKhr = 8,
        [NativeName("Name", "VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT")]
        Access2InputAttachmentReadBit = 16,
        [NativeName("Name", "VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR")]
        Access2InputAttachmentReadBitKhr = 16,
        [NativeName("Name", "VK_ACCESS_2_SHADER_READ_BIT")]
        Access2ShaderReadBit = 32,
        [NativeName("Name", "VK_ACCESS_2_SHADER_READ_BIT_KHR")]
        Access2ShaderReadBitKhr = 32,
        [NativeName("Name", "VK_ACCESS_2_SHADER_WRITE_BIT")]
        Access2ShaderWriteBit = 64,
        [NativeName("Name", "VK_ACCESS_2_SHADER_WRITE_BIT_KHR")]
        Access2ShaderWriteBitKhr = 64,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT")]
        Access2ColorAttachmentReadBit = 128,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR")]
        Access2ColorAttachmentReadBitKhr = 128,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT")]
        Access2ColorAttachmentWriteBit = 256,
        [NativeName("Name", "VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR")]
        Access2ColorAttachmentWriteBitKhr = 256,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT")]
        Access2DepthStencilAttachmentReadBit = 512,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR")]
        Access2DepthStencilAttachmentReadBitKhr = 512,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT")]
        Access2DepthStencilAttachmentWriteBit = 1024,
        [NativeName("Name", "VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR")]
        Access2DepthStencilAttachmentWriteBitKhr = 1024,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_READ_BIT")]
        Access2TransferReadBit = 2048,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_READ_BIT_KHR")]
        Access2TransferReadBitKhr = 2048,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_WRITE_BIT")]
        Access2TransferWriteBit = 4096,
        [NativeName("Name", "VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR")]
        Access2TransferWriteBitKhr = 4096,
        [NativeName("Name", "VK_ACCESS_2_HOST_READ_BIT")]
        Access2HostReadBit = 8192,
        [NativeName("Name", "VK_ACCESS_2_HOST_READ_BIT_KHR")]
        Access2HostReadBitKhr = 8192,
        [NativeName("Name", "VK_ACCESS_2_HOST_WRITE_BIT")]
        Access2HostWriteBit = 16384,
        [NativeName("Name", "VK_ACCESS_2_HOST_WRITE_BIT_KHR")]
        Access2HostWriteBitKhr = 16384,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_READ_BIT")]
        Access2MemoryReadBit = 32768,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_READ_BIT_KHR")]
        Access2MemoryReadBitKhr = 32768,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_WRITE_BIT")]
        Access2MemoryWriteBit = 65536,
        [NativeName("Name", "VK_ACCESS_2_MEMORY_WRITE_BIT_KHR")]
        Access2MemoryWriteBitKhr = 65536,
        [NativeName("Name", "VK_ACCESS_2_SHADER_SAMPLED_READ_BIT")]
        Access2ShaderSampledReadBit = 4294967296,
        [NativeName("Name", "VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR")]
        Access2ShaderSampledReadBitKhr = 4294967296,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_READ_BIT")]
        Access2ShaderStorageReadBit = 8589934592,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR")]
        Access2ShaderStorageReadBitKhr = 8589934592,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT")]
        Access2ShaderStorageWriteBit = 17179869184,
        [NativeName("Name", "VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR")]
        Access2ShaderStorageWriteBitKhr = 17179869184,
    }
}
