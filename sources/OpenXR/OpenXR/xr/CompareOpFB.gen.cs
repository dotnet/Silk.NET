// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompareOpFB")]
public enum CompareOpFB : uint
{
    [NativeName("XR_COMPARE_OP_NEVER_FB")]
    Never = 0,

    [NativeName("XR_COMPARE_OP_LESS_FB")]
    Less = 1,

    [NativeName("XR_COMPARE_OP_EQUAL_FB")]
    Equal = 2,

    [NativeName("XR_COMPARE_OP_LESS_OR_EQUAL_FB")]
    LessOrEqual = 3,

    [NativeName("XR_COMPARE_OP_GREATER_FB")]
    Greater = 4,

    [NativeName("XR_COMPARE_OP_NOT_EQUAL_FB")]
    NotEqual = 5,

    [NativeName("XR_COMPARE_OP_GREATER_OR_EQUAL_FB")]
    GreaterOrEqual = 6,

    [NativeName("XR_COMPARE_OP_ALWAYS_FB")]
    Always = 7,
}
