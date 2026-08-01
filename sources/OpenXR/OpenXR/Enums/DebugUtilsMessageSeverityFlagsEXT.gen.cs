// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrDebugUtilsMessageSeverityFlagsEXT")]
[Flags]
public enum DebugUtilsMessageSeverityFlagsEXT : ulong
{
    None = 0x0,

    [NativeName("XR_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT")]
    VerboseBit = 0x1,

    [NativeName("XR_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT")]
    InfoBit = 0x10,

    [NativeName("XR_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT")]
    WarningBit = 0x100,

    [NativeName("XR_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT")]
    ErrorBit = 0x1000,
}
