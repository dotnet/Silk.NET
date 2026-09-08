// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrDebugUtilsMessageTypeFlagsEXT")]
[Flags]
public enum DebugUtilsMessageTypeFlagsEXT : ulong
{
    None = 0x0,

    [NativeName("XR_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT")]
    GeneralBit = 0x1,

    [NativeName("XR_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT")]
    ValidationBit = 0x2,

    [NativeName("XR_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT")]
    PerformanceBit = 0x4,

    [NativeName("XR_DEBUG_UTILS_MESSAGE_TYPE_CONFORMANCE_BIT_EXT")]
    ConformanceBit = 0x8,
}
