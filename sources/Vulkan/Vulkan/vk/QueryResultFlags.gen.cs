// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueryResultFlags")]
[Flags]
public enum QueryResultFlags : uint
{
    None = 0x0,

    [NativeName("VK_QUERY_RESULT_64_BIT")]
    Result64Bit = 0x1,

    [NativeName("VK_QUERY_RESULT_WAIT_BIT")]
    ResultWaitBit = 0x2,

    [NativeName("VK_QUERY_RESULT_WITH_AVAILABILITY_BIT")]
    ResultWithAvailabilityBit = 0x4,

    [NativeName("VK_QUERY_RESULT_PARTIAL_BIT")]
    ResultPartialBit = 0x8,

    [NativeName("VK_QUERY_RESULT_WITH_STATUS_BIT_KHR")]
    ResultWithStatusBitKHR = 0x10,
}
