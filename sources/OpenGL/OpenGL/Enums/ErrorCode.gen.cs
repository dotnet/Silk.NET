// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ErrorCode")]
public enum ErrorCode : uint
{
    [NativeName("GL_NO_ERROR")]
    NoError = 0,

    [NativeName("GL_INVALID_ENUM")]
    InvalidEnum = 1280,

    [NativeName("GL_INVALID_VALUE")]
    InvalidValue = 1281,

    [NativeName("GL_INVALID_OPERATION")]
    InvalidOperation = 1282,

    [NativeName("GL_OUT_OF_MEMORY")]
    OutOfMemory = 1285,

    [NativeName("GL_STACK_OVERFLOW")]
    StackOverflow = 1283,

    [NativeName("GL_STACK_UNDERFLOW")]
    StackUnderflow = 1284,

    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION")]
    InvalidFramebufferOperation = 1286,

    [NativeName("GL_TABLE_TOO_LARGE")]
    TableTooLarge = 32817,

    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION_EXT")]
    InvalidFramebufferOperationEXT = 1286,

    [NativeName("GL_TABLE_TOO_LARGE_EXT")]
    TableTooLargeEXT = 32817,

    [NativeName("GL_TEXTURE_TOO_LARGE_EXT")]
    TextureTooLargeEXT = 32869,

    [NativeName("GL_INVALID_FRAMEBUFFER_OPERATION_OES")]
    InvalidFramebufferOperationOES = 1286,
}
