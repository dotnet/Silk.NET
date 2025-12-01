// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ContextProfileMask")]
[Flags]
public enum ContextProfileMask : uint
{
    [NativeName("GL_CONTEXT_CORE_PROFILE_BIT")]
    CoreProfileBit = unchecked((uint)0x00000001),

    [NativeName("GL_CONTEXT_COMPATIBILITY_PROFILE_BIT")]
    CompatibilityProfileBit = unchecked((uint)0x00000002),
}
