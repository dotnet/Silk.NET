// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ErrorCode : uint
{
    NoError = unchecked((uint)0),
    InvalidEnum = unchecked((uint)0x0500),
    InvalidValue = unchecked((uint)0x0501),
    InvalidOperation = unchecked((uint)0x0502),
    OutOfMemory = unchecked((uint)0x0505),
    StackOverflow = unchecked((uint)0x0503),
    StackUnderflow = unchecked((uint)0x0504),
    InvalidFramebufferOperation = unchecked((uint)0x0506),
    TableTooLarge = unchecked((uint)0x8031),
    InvalidFramebufferOperationEXT = unchecked((uint)0x0506),
    TableTooLargeEXT = unchecked((uint)0x8031),
    TextureTooLargeEXT = unchecked((uint)0x8065),
    InvalidFramebufferOperationOES = unchecked((uint)0x0506),
}
