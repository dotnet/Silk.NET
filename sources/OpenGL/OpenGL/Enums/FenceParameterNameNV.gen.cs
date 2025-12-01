// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FenceParameterNameNV")]
public enum FenceParameterNameNV : uint
{
    [NativeName("GL_FENCE_STATUS_NV")]
    StatusNV = unchecked((uint)0x84F3),

    [NativeName("GL_FENCE_CONDITION_NV")]
    ConditionNV = unchecked((uint)0x84F4),
}
