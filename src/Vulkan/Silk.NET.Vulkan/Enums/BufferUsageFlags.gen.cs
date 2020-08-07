// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum BufferUsageFlags
    {
        BufferUsageTransferSrcBit = 1,
        BufferUsageTransferDstBit = 2,
        BufferUsageUniformTexelBufferBit = 4,
        BufferUsageStorageTexelBufferBit = 8,
        BufferUsageUniformBufferBit = 16,
        BufferUsageStorageBufferBit = 32,
        BufferUsageIndexBufferBit = 64,
        BufferUsageVertexBufferBit = 128,
        BufferUsageIndirectBufferBit = 256,
        BufferUsageReserved15BitKhr = 32768,
        BufferUsageReserved16BitKhr = 65536,
        BufferUsageReserved13BitKhr = 8192,
        BufferUsageReserved14BitKhr = 16384,
        BufferUsageTransformFeedbackBufferBitExt = 2048,
        BufferUsageTransformFeedbackCounterBufferBitExt = 4096,
        BufferUsageConditionalRenderingBitExt = 512,
        BufferUsageRayTracingBitKhr = 1024,
        BufferUsageRayTracingBitNV = 1024,
        BufferUsageReserved19BitKhr = 524288,
        BufferUsageReserved20BitKhr = 1048576,
        BufferUsageReserved18BitQCom = 262144,
        BufferUsageShaderDeviceAddressBitExt = 131072,
        BufferUsageShaderDeviceAddressBitKhr = 131072,
        BufferUsageShaderDeviceAddressBit = 131072,
    }
}
