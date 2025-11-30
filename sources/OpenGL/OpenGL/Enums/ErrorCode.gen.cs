// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ErrorCode")]
[Transformed]
public enum ErrorCode : uint
{
    [NativeName("GL_NO_ERROR")]
    NoError = unchecked((uint)0),

    [NativeName("GL_INVALID_ENUM")]
    InvalidEnum = unchecked((uint)0x0500),

    [NativeName("GL_INVALID_VALUE")]
    InvalidValue = unchecked((uint)0x0501),

    [NativeName("GL_INVALID_OPERATION")]
    InvalidOperation = unchecked((uint)0x0502),

    [NativeName("GL_OUT_OF_MEMORY")]
    OutOfMemory = unchecked((uint)0x0505),

    [NativeName("GL_STACK_OVERFLOW")]
    StackOverflow = unchecked((uint)0x0503),

    [NativeName("GL_STACK_UNDERFLOW")]
    StackUnderflow = unchecked((uint)0x0504),

    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION")]
    InvalidFramebufferOperation = unchecked((uint)0x0506),

    [NativeName("GL_TABLE_TOO_LARGE")]
    TableTooLarge = unchecked((uint)0x8031),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION_EXT")]
    InvalidFramebufferOperationext = unchecked((uint)0x0506),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TABLE_TOO_LARGE_EXT")]
    TableTooLargeext = unchecked((uint)0x8031),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_TEXTURE_TOO_LARGE_EXT")]
    TextureTooLargeext = unchecked((uint)0x8065),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION_OES")]
    InvalidFramebufferOperationoes = unchecked((uint)0x0506),
}
