// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum CopyBufferSubDataTarget : uint
{
    ArrayBuffer = 0x8892,
    ElementArrayBuffer = 0x8893,
    PixelPackBuffer = 0x88EB,
    PixelUnpackBuffer = 0x88EC,
    TransformFeedbackBuffer = 0x8C8E,
    TextureBuffer = 0x8C2A,
    CopyReadBuffer = 0x8F36,
    CopyWriteBuffer = 0x8F37,
    UniformBuffer = 0x8A11,
    DrawIndirectBuffer = 0x8F3F,
    AtomicCounterBuffer = 0x92C0,
    DispatchIndirectBuffer = 0x90EE,
    ShaderStorageBuffer = 0x90D2,
    QueryBuffer = 0x9192
}
