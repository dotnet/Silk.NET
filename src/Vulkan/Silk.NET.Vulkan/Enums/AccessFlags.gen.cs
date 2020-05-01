// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum AccessFlags
    {
        AccessIndirectCommandReadBit = 1,
        AccessIndexReadBit = 2,
        AccessVertexAttributeReadBit = 4,
        AccessUniformReadBit = 8,
        AccessInputAttachmentReadBit = 16,
        AccessShaderReadBit = 32,
        AccessShaderWriteBit = 64,
        AccessColorAttachmentReadBit = 128,
        AccessColorAttachmentWriteBit = 256,
        AccessDepthStencilAttachmentReadBit = 512,
        AccessDepthStencilAttachmentWriteBit = 1024,
        AccessTransferReadBit = 2048,
        AccessTransferWriteBit = 4096,
        AccessHostReadBit = 8192,
        AccessHostWriteBit = 16384,
        AccessMemoryReadBit = 32768,
        AccessMemoryWriteBit = 65536,
        AccessReserved30BitKhr = 1073741824,
        AccessReserved28BitKhr = 268435456,
        AccessReserved29BitKhr = 536870912,
        AccessTransformFeedbackWriteBitExt = 33554432,
        AccessTransformFeedbackCounterReadBitExt = 67108864,
        AccessTransformFeedbackCounterWriteBitExt = 134217728,
        AccessConditionalRenderingReadBitExt = 1048576,
        AccessColorAttachmentReadNoncoherentBitExt = 524288,
        AccessAccelerationStructureReadBitKhr = 2097152,
        AccessAccelerationStructureWriteBitKhr = 4194304,
        AccessShadingRateImageReadBitNV = 8388608,
        AccessAccelerationStructureReadBitNV = 2097152,
        AccessAccelerationStructureWriteBitNV = 4194304,
        AccessFragmentDensityMapReadBitExt = 16777216,
        AccessCommandPreprocessReadBitNV = 131072,
        AccessCommandPreprocessWriteBitNV = 262144,
    }
}
