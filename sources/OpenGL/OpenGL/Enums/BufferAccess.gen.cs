// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ARB", -1)]
[NativeName("BufferAccessARB")]
public enum BufferAccess : uint
{
    [NativeName("GL_READ_ONLY")]
    ReadOnly = 35000,

    [NativeName("GL_WRITE_ONLY")]
    WriteOnly = 35001,

    [NativeName("GL_READ_WRITE")]
    ReadWrite = 35002,
}
