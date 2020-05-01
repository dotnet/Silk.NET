// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum MemoryBarrierMask
    {
        VertexAttribArrayBarrierBit = 0x1,
        VertexAttribArrayBarrierBitExt = 0x1,
        ElementArrayBarrierBit = 0x2,
        ElementArrayBarrierBitExt = 0x2,
        UniformBarrierBit = 0x4,
        UniformBarrierBitExt = 0x4,
        TextureFetchBarrierBit = 0x8,
        TextureFetchBarrierBitExt = 0x8,
        ShaderGlobalAccessBarrierBitNV = 0x10,
        ShaderImageAccessBarrierBit = 0x20,
        ShaderImageAccessBarrierBitExt = 0x20,
        CommandBarrierBit = 0x40,
        CommandBarrierBitExt = 0x40,
        PixelBufferBarrierBit = 0x80,
        PixelBufferBarrierBitExt = 0x80,
        TextureUpdateBarrierBit = 0x100,
        TextureUpdateBarrierBitExt = 0x100,
        BufferUpdateBarrierBit = 0x200,
        BufferUpdateBarrierBitExt = 0x200,
        FramebufferBarrierBit = 0x400,
        FramebufferBarrierBitExt = 0x400,
        TransformFeedbackBarrierBit = 0x800,
        TransformFeedbackBarrierBitExt = 0x800,
        AtomicCounterBarrierBit = 0x1000,
        AtomicCounterBarrierBitExt = 0x1000,
        ShaderStorageBarrierBit = 0x2000,
        ClientMappedBufferBarrierBit = 0x4000,
        ClientMappedBufferBarrierBitExt = 0x4000,
        QueryBufferBarrierBit = 0x8000,
        AllBarrierBits = unchecked((int)0xFFFFFFFF),
        AllBarrierBitsExt = unchecked((int)0xFFFFFFFF),
    }
}
