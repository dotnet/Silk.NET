// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ContextFlagMask")]
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

    [NativeName("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB")]
    RobustAccessBitARB = unchecked((uint)0x00000004),

    [NativeName("GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR")]
    NoErrorBitKHR = unchecked((uint)0x00000008),

    [NativeName("GL_CONTEXT_FLAG_DEBUG_BIT_KHR")]
    DebugBitKHR = unchecked((uint)0x00000002),

    [NativeName("GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT")]
    ProtectedContentBitEXT = unchecked((uint)0x00000010),
}
