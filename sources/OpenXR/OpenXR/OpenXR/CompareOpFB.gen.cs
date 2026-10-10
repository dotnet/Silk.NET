// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompareOpFB")]
[SupportedApiProfile("openxr")]
public enum CompareOpFB : uint
{
    [NativeName("XR_COMPARE_OP_NEVER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    Never = 0,

    [NativeName("XR_COMPARE_OP_LESS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    Less = 1,

    [NativeName("XR_COMPARE_OP_EQUAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    Equal = 2,

    [NativeName("XR_COMPARE_OP_LESS_OR_EQUAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    LessOrEqual = 3,

    [NativeName("XR_COMPARE_OP_GREATER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    Greater = 4,

    [NativeName("XR_COMPARE_OP_NOT_EQUAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    NotEqual = 5,

    [NativeName("XR_COMPARE_OP_GREATER_OR_EQUAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    GreaterOrEqual = 6,

    [NativeName("XR_COMPARE_OP_ALWAYS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    Always = 7,
}
