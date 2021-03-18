// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ErrorCode")]
    public enum ErrorCode : int
    {
        [NativeName("Name", "GL_NO_ERROR")]
        NoError = 0x0,
        [NativeName("Name", "GL_INVALID_ENUM")]
        InvalidEnum = 0x500,
        [NativeName("Name", "GL_INVALID_VALUE")]
        InvalidValue = 0x501,
        [NativeName("Name", "GL_INVALID_OPERATION")]
        InvalidOperation = 0x502,
        [NativeName("Name", "GL_STACK_OVERFLOW")]
        StackOverflow = 0x503,
        [NativeName("Name", "GL_STACK_UNDERFLOW")]
        StackUnderflow = 0x504,
        [NativeName("Name", "GL_OUT_OF_MEMORY")]
        OutOfMemory = 0x505,
        [NativeName("Name", "GL_INVALID_FRAMEBUFFER_OPERATION")]
        InvalidFramebufferOperation = 0x506,
        [NativeName("Name", "GL_INVALID_FRAMEBUFFER_OPERATION_EXT")]
        InvalidFramebufferOperationExt = 0x506,
        [NativeName("Name", "GL_INVALID_FRAMEBUFFER_OPERATION_OES")]
        InvalidFramebufferOperationOes = 0x506,
        [NativeName("Name", "GL_TABLE_TOO_LARGE_EXT")]
        TableTooLargeExt = 0x8031,
        [NativeName("Name", "GL_TABLE_TOO_LARGE")]
        TableTooLarge = 0x8031,
        [NativeName("Name", "GL_TEXTURE_TOO_LARGE_EXT")]
        TextureTooLargeExt = 0x8065,
    }
}
