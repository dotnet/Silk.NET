// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "BufferTargetARB")]
    public enum BufferTargetARB : int
    {
        [NativeName("Name", "GL_PARAMETER_BUFFER")]
        ParameterBuffer = 0x80EE,
        [NativeName("Name", "GL_ARRAY_BUFFER")]
        ArrayBuffer = 0x8892,
        [NativeName("Name", "GL_ELEMENT_ARRAY_BUFFER")]
        ElementArrayBuffer = 0x8893,
        [NativeName("Name", "GL_PIXEL_PACK_BUFFER")]
        PixelPackBuffer = 0x88EB,
        [NativeName("Name", "GL_PIXEL_UNPACK_BUFFER")]
        PixelUnpackBuffer = 0x88EC,
        [NativeName("Name", "GL_UNIFORM_BUFFER")]
        UniformBuffer = 0x8A11,
        [NativeName("Name", "GL_TEXTURE_BUFFER")]
        TextureBuffer = 0x8C2A,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER")]
        TransformFeedbackBuffer = 0x8C8E,
        [NativeName("Name", "GL_COPY_READ_BUFFER")]
        CopyReadBuffer = 0x8F36,
        [NativeName("Name", "GL_COPY_WRITE_BUFFER")]
        CopyWriteBuffer = 0x8F37,
        [NativeName("Name", "GL_DRAW_INDIRECT_BUFFER")]
        DrawIndirectBuffer = 0x8F3F,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER")]
        ShaderStorageBuffer = 0x90D2,
        [NativeName("Name", "GL_DISPATCH_INDIRECT_BUFFER")]
        DispatchIndirectBuffer = 0x90EE,
        [NativeName("Name", "GL_QUERY_BUFFER")]
        QueryBuffer = 0x9192,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER")]
        AtomicCounterBuffer = 0x92C0,
    }
}
