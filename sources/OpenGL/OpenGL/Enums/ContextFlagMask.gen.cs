// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ContextFlagMask")]
[Transformed]
[Flags]
public enum ContextFlagMask : uint
{
    [NativeName("GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT")]
    ForwardCompatibleBit = unchecked((uint)0x00000001),

    [NativeName("GL_CONTEXT_FLAG_DEBUG_BIT")]
    DebugBit = unchecked((uint)0x00000002),

    [NativeName("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT")]
    RobustAccessBit = unchecked((uint)0x00000004),

    [NativeName("GL_CONTEXT_FLAG_NO_ERROR_BIT")]
    NoErrorBit = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB")]
    RobustAccessBitarb = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR")]
    NoErrorBitkhr = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_CONTEXT_FLAG_DEBUG_BIT_KHR")]
    DebugBitkhr = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT")]
    ProtectedContentBitext = unchecked((uint)0x00000010),
}
