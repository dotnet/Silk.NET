// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PreserveModeATI")]
public enum PreserveModeATI : uint
{
    [NativeName("GL_PRESERVE_ATI")]
    Preserve = unchecked((uint)0x8762),

    [NativeName("GL_DISCARD_ATI")]
    Discard = unchecked((uint)0x8763),
}
