// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("MemoryBarrierMask")]
[Transformed]
[Flags]
public enum MemoryBarrierMask : uint
{
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT")]
    VertexAttribArrayBarrierBit = unchecked((uint)0x00000001),

    [NativeName("GL_ELEMENT_ARRAY_BARRIER_BIT")]
    ElementArrayBarrierBit = unchecked((uint)0x00000002),

    [NativeName("GL_UNIFORM_BARRIER_BIT")]
    UniformBarrierBit = unchecked((uint)0x00000004),

    [NativeName("GL_TEXTURE_FETCH_BARRIER_BIT")]
    TextureFetchBarrierBit = unchecked((uint)0x00000008),

    [NativeName("GL_SHADER_IMAGE_ACCESS_BARRIER_BIT")]
    ShaderImageAccessBarrierBit = unchecked((uint)0x00000020),

    [NativeName("GL_COMMAND_BARRIER_BIT")]
    CommandBarrierBit = unchecked((uint)0x00000040),

    [NativeName("GL_PIXEL_BUFFER_BARRIER_BIT")]
    PixelBufferBarrierBit = unchecked((uint)0x00000080),

    [NativeName("GL_TEXTURE_UPDATE_BARRIER_BIT")]
    TextureUpdateBarrierBit = unchecked((uint)0x00000100),

    [NativeName("GL_BUFFER_UPDATE_BARRIER_BIT")]
    BufferUpdateBarrierBit = unchecked((uint)0x00000200),

    [NativeName("GL_FRAMEBUFFER_BARRIER_BIT")]
    FramebufferBarrierBit = unchecked((uint)0x00000400),

    [NativeName("GL_TRANSFORM_FEEDBACK_BARRIER_BIT")]
    TransformFeedbackBarrierBit = unchecked((uint)0x00000800),

    [NativeName("GL_ATOMIC_COUNTER_BARRIER_BIT")]
    AtomicCounterBarrierBit = unchecked((uint)0x00001000),

    [NativeName("GL_ALL_BARRIER_BITS")]
    AllBarrierBits = unchecked((uint)0xFFFFFFFF),

    [NativeName("GL_SHADER_STORAGE_BARRIER_BIT")]
    ShaderStorageBarrierBit = unchecked((uint)0x00002000),

    [NativeName("GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT")]
    ClientMappedBufferBarrierBit = unchecked((uint)0x00004000),

    [NativeName("GL_QUERY_BUFFER_BARRIER_BIT")]
    QueryBufferBarrierBit = unchecked((uint)0x00008000),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT")]
    VertexAttribArrayBarrierBitext = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ELEMENT_ARRAY_BARRIER_BIT_EXT")]
    ElementArrayBarrierBitext = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNIFORM_BARRIER_BIT_EXT")]
    UniformBarrierBitext = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_FETCH_BARRIER_BIT_EXT")]
    TextureFetchBarrierBitext = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT")]
    ShaderImageAccessBarrierBitext = unchecked((uint)0x00000020),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COMMAND_BARRIER_BIT_EXT")]
    CommandBarrierBitext = unchecked((uint)0x00000040),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_PIXEL_BUFFER_BARRIER_BIT_EXT")]
    PixelBufferBarrierBitext = unchecked((uint)0x00000080),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_UPDATE_BARRIER_BIT_EXT")]
    TextureUpdateBarrierBitext = unchecked((uint)0x00000100),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BUFFER_UPDATE_BARRIER_BIT_EXT")]
    BufferUpdateBarrierBitext = unchecked((uint)0x00000200),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_FRAMEBUFFER_BARRIER_BIT_EXT")]
    FramebufferBarrierBitext = unchecked((uint)0x00000400),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT")]
    TransformFeedbackBarrierBitext = unchecked((uint)0x00000800),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ATOMIC_COUNTER_BARRIER_BIT_EXT")]
    AtomicCounterBarrierBitext = unchecked((uint)0x00001000),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ALL_BARRIER_BITS_EXT")]
    AllBarrierBitsext = unchecked((uint)0xFFFFFFFF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV")]
    ShaderGlobalAccessBarrierBitnv = unchecked((uint)0x00000010),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT")]
    ClientMappedBufferBarrierBitext = unchecked((uint)0x00004000),
}
