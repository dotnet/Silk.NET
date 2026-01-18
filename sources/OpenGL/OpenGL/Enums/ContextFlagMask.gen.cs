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
    None = 0x0,

    [NativeName("GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT")]
    ForwardCompatibleBit = 0x1,

    [NativeName("GL_CONTEXT_FLAG_DEBUG_BIT")]
    DebugBit = 0x2,

    [NativeName("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT")]
    RobustAccessBit = 0x4,

    [NativeName("GL_CONTEXT_FLAG_NO_ERROR_BIT")]
    NoErrorBit = 0x8,

    [NativeName("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB")]
    RobustAccessBitARB = 0x4,

    [NativeName("GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR")]
    NoErrorBitKHR = 0x8,

    [NativeName("GL_CONTEXT_FLAG_DEBUG_BIT_KHR")]
    DebugBitKHR = 0x2,

    [NativeName("GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT")]
    ProtectedContentBitEXT = 0x10,
}
