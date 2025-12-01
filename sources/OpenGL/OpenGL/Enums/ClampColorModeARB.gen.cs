// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ClampColorModeARB")]
public enum ClampColorModeARB : uint
{
    [NativeName("GL_FALSE")]
    False = unchecked((uint)0),

    [NativeName("GL_TRUE")]
    True = unchecked((uint)1),

    [NativeName("GL_FIXED_ONLY")]
    FixedOnly = unchecked((uint)0x891D),

    [NativeName("GL_FIXED_ONLY_ARB")]
    FixedOnlyARB = unchecked((uint)0x891D),
}
