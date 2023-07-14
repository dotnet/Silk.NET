// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [Flags]
    [NativeName("Name", "MemoryBarrierMask")]
    public enum MemoryBarrierMask : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT")]
        VertexAttribArrayBarrierBit = 0x1,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT")]
        VertexAttribArrayBarrierBitExt = 0x1,
        [NativeName("Name", "GL_ELEMENT_ARRAY_BARRIER_BIT")]
        ElementArrayBarrierBit = 0x2,
        [NativeName("Name", "GL_ELEMENT_ARRAY_BARRIER_BIT_EXT")]
        ElementArrayBarrierBitExt = 0x2,
        [NativeName("Name", "GL_UNIFORM_BARRIER_BIT")]
        UniformBarrierBit = 0x4,
        [NativeName("Name", "GL_UNIFORM_BARRIER_BIT_EXT")]
        UniformBarrierBitExt = 0x4,
        [NativeName("Name", "GL_TEXTURE_FETCH_BARRIER_BIT")]
        TextureFetchBarrierBit = 0x8,
        [NativeName("Name", "GL_TEXTURE_FETCH_BARRIER_BIT_EXT")]
        TextureFetchBarrierBitExt = 0x8,
        [NativeName("Name", "GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV")]
        ShaderGlobalAccessBarrierBitNV = 0x10,
        [NativeName("Name", "GL_SHADER_IMAGE_ACCESS_BARRIER_BIT")]
        ShaderImageAccessBarrierBit = 0x20,
        [NativeName("Name", "GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT")]
        ShaderImageAccessBarrierBitExt = 0x20,
        [NativeName("Name", "GL_COMMAND_BARRIER_BIT")]
        CommandBarrierBit = 0x40,
        [NativeName("Name", "GL_COMMAND_BARRIER_BIT_EXT")]
        CommandBarrierBitExt = 0x40,
        [NativeName("Name", "GL_PIXEL_BUFFER_BARRIER_BIT")]
        PixelBufferBarrierBit = 0x80,
        [NativeName("Name", "GL_PIXEL_BUFFER_BARRIER_BIT_EXT")]
        PixelBufferBarrierBitExt = 0x80,
        [NativeName("Name", "GL_TEXTURE_UPDATE_BARRIER_BIT")]
        TextureUpdateBarrierBit = 0x100,
        [NativeName("Name", "GL_TEXTURE_UPDATE_BARRIER_BIT_EXT")]
        TextureUpdateBarrierBitExt = 0x100,
        [NativeName("Name", "GL_BUFFER_UPDATE_BARRIER_BIT")]
        BufferUpdateBarrierBit = 0x200,
        [NativeName("Name", "GL_BUFFER_UPDATE_BARRIER_BIT_EXT")]
        BufferUpdateBarrierBitExt = 0x200,
        [NativeName("Name", "GL_FRAMEBUFFER_BARRIER_BIT")]
        FramebufferBarrierBit = 0x400,
        [NativeName("Name", "GL_FRAMEBUFFER_BARRIER_BIT_EXT")]
        FramebufferBarrierBitExt = 0x400,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BARRIER_BIT")]
        TransformFeedbackBarrierBit = 0x800,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT")]
        TransformFeedbackBarrierBitExt = 0x800,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BARRIER_BIT")]
        AtomicCounterBarrierBit = 0x1000,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BARRIER_BIT_EXT")]
        AtomicCounterBarrierBitExt = 0x1000,
        [NativeName("Name", "GL_SHADER_STORAGE_BARRIER_BIT")]
        ShaderStorageBarrierBit = 0x2000,
        [NativeName("Name", "GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT")]
        ClientMappedBufferBarrierBit = 0x4000,
        [NativeName("Name", "GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT")]
        ClientMappedBufferBarrierBitExt = 0x4000,
        [NativeName("Name", "GL_QUERY_BUFFER_BARRIER_BIT")]
        QueryBufferBarrierBit = 0x8000,
        [NativeName("Name", "GL_ALL_BARRIER_BITS")]
        AllBarrierBits = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_ALL_BARRIER_BITS_EXT")]
        AllBarrierBitsExt = unchecked((int)0xFFFFFFFF),
    }
}
