// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ContextFlagMask")]
    public enum ContextFlagMask : int
    {
        [NativeName("Name", "GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT")]
        ContextFlagForwardCompatibleBit = 0x1,
        [NativeName("Name", "GL_CONTEXT_FLAG_DEBUG_BIT")]
        ContextFlagDebugBit = 0x2,
        [NativeName("Name", "GL_CONTEXT_FLAG_DEBUG_BIT_KHR")]
        ContextFlagDebugBitKhr = 0x2,
        [NativeName("Name", "GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT")]
        ContextFlagRobustAccessBit = 0x4,
        [NativeName("Name", "GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB")]
        ContextFlagRobustAccessBitArb = 0x4,
        [NativeName("Name", "GL_CONTEXT_FLAG_NO_ERROR_BIT")]
        ContextFlagNoErrorBit = 0x8,
        [NativeName("Name", "GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR")]
        ContextFlagNoErrorBitKhr = 0x8,
        [NativeName("Name", "GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT")]
        ContextFlagProtectedContentBitExt = 0x10,
    }
}
