// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("BufferTargetARB")]
public enum BufferTargetARB : uint
{
    [NativeName("GL_ARRAY_BUFFER")]
    ArrayBuffer = unchecked((uint)0x8892),

    [NativeName("GL_ELEMENT_ARRAY_BUFFER")]
    ElementArrayBuffer = unchecked((uint)0x8893),

    [NativeName("GL_PIXEL_PACK_BUFFER")]
    PixelPackBuffer = unchecked((uint)0x88EB),

    [NativeName("GL_PIXEL_UNPACK_BUFFER")]
    PixelUnpackBuffer = unchecked((uint)0x88EC),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER")]
    TransformFeedbackBuffer = unchecked((uint)0x8C8E),

    [NativeName("GL_TEXTURE_BUFFER")]
    TextureBuffer = unchecked((uint)0x8C2A),

    [NativeName("GL_COPY_READ_BUFFER")]
    CopyReadBuffer = unchecked((uint)0x8F36),

    [NativeName("GL_COPY_WRITE_BUFFER")]
    CopyWriteBuffer = unchecked((uint)0x8F37),

    [NativeName("GL_UNIFORM_BUFFER")]
    UniformBuffer = unchecked((uint)0x8A11),

    [NativeName("GL_DRAW_INDIRECT_BUFFER")]
    DrawIndirectBuffer = unchecked((uint)0x8F3F),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER")]
    AtomicCounterBuffer = unchecked((uint)0x92C0),

    [NativeName("GL_DISPATCH_INDIRECT_BUFFER")]
    DispatchIndirectBuffer = unchecked((uint)0x90EE),

    [NativeName("GL_SHADER_STORAGE_BUFFER")]
    ShaderStorageBuffer = unchecked((uint)0x90D2),

    [NativeName("GL_QUERY_BUFFER")]
    QueryBuffer = unchecked((uint)0x9192),

    [NativeName("GL_PARAMETER_BUFFER")]
    ParameterBuffer = unchecked((uint)0x80EE),
}
