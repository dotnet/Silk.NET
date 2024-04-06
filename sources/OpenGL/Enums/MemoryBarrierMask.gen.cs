// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum MemoryBarrierMask
{
    VertexAttribArrayBarrierBit = 0x00000001,
    ElementArrayBarrierBit = 0x00000002,
    UniformBarrierBit = 0x00000004,
    TextureFetchBarrierBit = 0x00000008,
    ShaderImageAccessBarrierBit = 0x00000020,
    CommandBarrierBit = 0x00000040,
    PixelBufferBarrierBit = 0x00000080,
    TextureUpdateBarrierBit = 0x00000100,
    BufferUpdateBarrierBit = 0x00000200,
    FramebufferBarrierBit = 0x00000400,
    TransformFeedbackBarrierBit = 0x00000800,
    AtomicCounterBarrierBit = 0x00001000,
    AllBarrierBits = 0xFFFFFFFF,
    ShaderStorageBarrierBit = 0x00002000,
    ClientMappedBufferBarrierBit = 0x00004000,
    QueryBufferBarrierBit = 0x00008000,
    ShaderGlobalAccessBarrierBitNV = 0x00000010,
    VertexAttribArrayBarrierBitEXT = 0x00000001,
    ElementArrayBarrierBitEXT = 0x00000002,
    UniformBarrierBitEXT = 0x00000004,
    TextureFetchBarrierBitEXT = 0x00000008,
    ShaderImageAccessBarrierBitEXT = 0x00000020,
    CommandBarrierBitEXT = 0x00000040,
    PixelBufferBarrierBitEXT = 0x00000080,
    TextureUpdateBarrierBitEXT = 0x00000100,
    BufferUpdateBarrierBitEXT = 0x00000200,
    FramebufferBarrierBitEXT = 0x00000400,
    TransformFeedbackBarrierBitEXT = 0x00000800,
    AtomicCounterBarrierBitEXT = 0x00001000,
    AllBarrierBitsEXT = 0xFFFFFFFF,
    ClientMappedBufferBarrierBitEXT = 0x00004000
}
