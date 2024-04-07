// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ErrorCode : uint
{
    NoError = 0,
    InvalidEnum = 0x0500,
    InvalidValue = 0x0501,
    InvalidOperation = 0x0502,
    OutOfMemory = 0x0505,
    StackOverflow = 0x0503,
    StackUnderflow = 0x0504,
    InvalidFramebufferOperation = 0x0506,
    TableTooLarge = 0x8031,
    InvalidFramebufferOperationEXT = 0x0506,
    TableTooLargeEXT = 0x8031,
    TextureTooLargeEXT = 0x8065,
    InvalidFramebufferOperationOES = 0x0506
}
