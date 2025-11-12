// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum BufferStorageTarget : uint
{
    ArrayBuffer = unchecked((uint)0x8892),
    ElementArrayBuffer = unchecked((uint)0x8893),
    PixelPackBuffer = unchecked((uint)0x88EB),
    PixelUnpackBuffer = unchecked((uint)0x88EC),
    TransformFeedbackBuffer = unchecked((uint)0x8C8E),
    TextureBuffer = unchecked((uint)0x8C2A),
    CopyReadBuffer = unchecked((uint)0x8F36),
    CopyWriteBuffer = unchecked((uint)0x8F37),
    UniformBuffer = unchecked((uint)0x8A11),
    DrawIndirectBuffer = unchecked((uint)0x8F3F),
    AtomicCounterBuffer = unchecked((uint)0x92C0),
    DispatchIndirectBuffer = unchecked((uint)0x90EE),
    ShaderStorageBuffer = unchecked((uint)0x90D2),
    QueryBuffer = unchecked((uint)0x9192),
}
