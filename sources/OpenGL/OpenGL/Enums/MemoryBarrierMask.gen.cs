// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MemoryBarrierMask")]
[Flags]
public enum MemoryBarrierMask : uint
{
    None = 0x0,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT")]
    VertexAttribArrayBarrierBit = 0x1,

    [NativeName("GL_ELEMENT_ARRAY_BARRIER_BIT")]
    ElementArrayBarrierBit = 0x2,

    [NativeName("GL_UNIFORM_BARRIER_BIT")]
    UniformBarrierBit = 0x4,

    [NativeName("GL_TEXTURE_FETCH_BARRIER_BIT")]
    TextureFetchBarrierBit = 0x8,

    [NativeName("GL_SHADER_IMAGE_ACCESS_BARRIER_BIT")]
    ShaderImageAccessBarrierBit = 0x20,

    [NativeName("GL_COMMAND_BARRIER_BIT")]
    CommandBarrierBit = 0x40,

    [NativeName("GL_PIXEL_BUFFER_BARRIER_BIT")]
    PixelBufferBarrierBit = 0x80,

    [NativeName("GL_TEXTURE_UPDATE_BARRIER_BIT")]
    TextureUpdateBarrierBit = 0x100,

    [NativeName("GL_BUFFER_UPDATE_BARRIER_BIT")]
    BufferUpdateBarrierBit = 0x200,

    [NativeName("GL_FRAMEBUFFER_BARRIER_BIT")]
    FramebufferBarrierBit = 0x400,

    [NativeName("GL_TRANSFORM_FEEDBACK_BARRIER_BIT")]
    TransformFeedbackBarrierBit = 0x800,

    [NativeName("GL_ATOMIC_COUNTER_BARRIER_BIT")]
    AtomicCounterBarrierBit = 0x1000,

    [NativeName("GL_ALL_BARRIER_BITS")]
    AllBarrierBits = 0xFFFFFFFF,

    [NativeName("GL_SHADER_STORAGE_BARRIER_BIT")]
    ShaderStorageBarrierBit = 0x2000,

    [NativeName("GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT")]
    ClientMappedBufferBarrierBit = 0x4000,

    [NativeName("GL_QUERY_BUFFER_BARRIER_BIT")]
    QueryBufferBarrierBit = 0x8000,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT")]
    VertexAttribArrayBarrierBitEXT = 0x1,

    [NativeName("GL_ELEMENT_ARRAY_BARRIER_BIT_EXT")]
    ElementArrayBarrierBitEXT = 0x2,

    [NativeName("GL_UNIFORM_BARRIER_BIT_EXT")]
    UniformBarrierBitEXT = 0x4,

    [NativeName("GL_TEXTURE_FETCH_BARRIER_BIT_EXT")]
    TextureFetchBarrierBitEXT = 0x8,

    [NativeName("GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT")]
    ShaderImageAccessBarrierBitEXT = 0x20,

    [NativeName("GL_COMMAND_BARRIER_BIT_EXT")]
    CommandBarrierBitEXT = 0x40,

    [NativeName("GL_PIXEL_BUFFER_BARRIER_BIT_EXT")]
    PixelBufferBarrierBitEXT = 0x80,

    [NativeName("GL_TEXTURE_UPDATE_BARRIER_BIT_EXT")]
    TextureUpdateBarrierBitEXT = 0x100,

    [NativeName("GL_BUFFER_UPDATE_BARRIER_BIT_EXT")]
    BufferUpdateBarrierBitEXT = 0x200,

    [NativeName("GL_FRAMEBUFFER_BARRIER_BIT_EXT")]
    FramebufferBarrierBitEXT = 0x400,

    [NativeName("GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT")]
    TransformFeedbackBarrierBitEXT = 0x800,

    [NativeName("GL_ATOMIC_COUNTER_BARRIER_BIT_EXT")]
    AtomicCounterBarrierBitEXT = 0x1000,

    [NativeName("GL_ALL_BARRIER_BITS_EXT")]
    AllBarrierBitsEXT = 0xFFFFFFFF,

    [NativeName("GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV")]
    ShaderGlobalAccessBarrierBitNV = 0x10,

    [NativeName("GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT")]
    ClientMappedBufferBarrierBitEXT = 0x4000,
}
