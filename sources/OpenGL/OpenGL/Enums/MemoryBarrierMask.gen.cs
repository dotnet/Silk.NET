// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum MemoryBarrierMask : uint
{
    VertexAttribArrayBarrierBit = unchecked((uint)0x00000001),
    ElementArrayBarrierBit = unchecked((uint)0x00000002),
    UniformBarrierBit = unchecked((uint)0x00000004),
    TextureFetchBarrierBit = unchecked((uint)0x00000008),
    ShaderImageAccessBarrierBit = unchecked((uint)0x00000020),
    CommandBarrierBit = unchecked((uint)0x00000040),
    PixelBufferBarrierBit = unchecked((uint)0x00000080),
    TextureUpdateBarrierBit = unchecked((uint)0x00000100),
    BufferUpdateBarrierBit = unchecked((uint)0x00000200),
    FramebufferBarrierBit = unchecked((uint)0x00000400),
    TransformFeedbackBarrierBit = unchecked((uint)0x00000800),
    AtomicCounterBarrierBit = unchecked((uint)0x00001000),
    AllBarrierBits = unchecked((uint)0xFFFFFFFF),
    ShaderStorageBarrierBit = unchecked((uint)0x00002000),
    ClientMappedBufferBarrierBit = unchecked((uint)0x00004000),
    QueryBufferBarrierBit = unchecked((uint)0x00008000),
    VertexAttribArrayBarrierBitEXT = unchecked((uint)0x00000001),
    ElementArrayBarrierBitEXT = unchecked((uint)0x00000002),
    UniformBarrierBitEXT = unchecked((uint)0x00000004),
    TextureFetchBarrierBitEXT = unchecked((uint)0x00000008),
    ShaderImageAccessBarrierBitEXT = unchecked((uint)0x00000020),
    CommandBarrierBitEXT = unchecked((uint)0x00000040),
    PixelBufferBarrierBitEXT = unchecked((uint)0x00000080),
    TextureUpdateBarrierBitEXT = unchecked((uint)0x00000100),
    BufferUpdateBarrierBitEXT = unchecked((uint)0x00000200),
    FramebufferBarrierBitEXT = unchecked((uint)0x00000400),
    TransformFeedbackBarrierBitEXT = unchecked((uint)0x00000800),
    AtomicCounterBarrierBitEXT = unchecked((uint)0x00001000),
    AllBarrierBitsEXT = unchecked((uint)0xFFFFFFFF),
    ShaderGlobalAccessBarrierBitNV = unchecked((uint)0x00000010),
    ClientMappedBufferBarrierBitEXT = unchecked((uint)0x00004000),
}
