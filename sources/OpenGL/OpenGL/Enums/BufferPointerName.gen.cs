// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "ARB", -1)]
[NativeName("BufferPointerNameARB")]
public enum BufferPointerName : uint
{
    [NativeName("GL_BUFFER_MAP_POINTER")]
    Pointer = 35005,

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_BUFFER_MAP_POINTER_ARB")]
    PointerARB = 35005,
}
