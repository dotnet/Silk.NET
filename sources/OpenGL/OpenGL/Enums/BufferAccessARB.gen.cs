// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ARB", 0)]
[NativeName("BufferAccessARB")]
[Transformed]
public enum BufferAccessARB : uint
{
    [NativeName("GL_READ_ONLY")]
    ReadOnly = unchecked((uint)0x88B8),

    [NativeName("GL_WRITE_ONLY")]
    WriteOnly = unchecked((uint)0x88B9),

    [NativeName("GL_READ_WRITE")]
    ReadWrite = unchecked((uint)0x88BA),
}
