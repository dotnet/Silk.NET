// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ARB", -1)]
[NativeName("BufferTargetARB")]
public enum BufferTarget : uint
{
    [NativeName("GL_ARRAY_BUFFER")]
    ArrayBuffer = 34962,

    [NativeName("GL_ELEMENT_ARRAY_BUFFER")]
    ElementArrayBuffer = 34963,

    [NativeName("GL_PIXEL_PACK_BUFFER")]
    PixelPackBuffer = 35051,

    [NativeName("GL_PIXEL_UNPACK_BUFFER")]
    PixelUnpackBuffer = 35052,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER")]
    TransformFeedbackBuffer = 35982,

    [NativeName("GL_TEXTURE_BUFFER")]
    TextureBuffer = 35882,

    [NativeName("GL_COPY_READ_BUFFER")]
    CopyReadBuffer = 36662,

    [NativeName("GL_COPY_WRITE_BUFFER")]
    CopyWriteBuffer = 36663,

    [NativeName("GL_UNIFORM_BUFFER")]
    UniformBuffer = 35345,

    [NativeName("GL_DRAW_INDIRECT_BUFFER")]
    DrawIndirectBuffer = 36671,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER")]
    AtomicCounterBuffer = 37568,

    [NativeName("GL_DISPATCH_INDIRECT_BUFFER")]
    DispatchIndirectBuffer = 37102,

    [NativeName("GL_SHADER_STORAGE_BUFFER")]
    ShaderStorageBuffer = 37074,

    [NativeName("GL_QUERY_BUFFER")]
    QueryBuffer = 37266,

    [NativeName("GL_PARAMETER_BUFFER")]
    ParameterBuffer = 33006,
}
