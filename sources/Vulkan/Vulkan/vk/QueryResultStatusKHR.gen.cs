// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueryResultStatusKHR")]
public enum QueryResultStatusKHR
{
    [NativeName("VK_QUERY_RESULT_STATUS_ERROR_KHR")]
    Error = -1,

    [NativeName("VK_QUERY_RESULT_STATUS_NOT_READY_KHR")]
    NotReady = 0,

    [NativeName("VK_QUERY_RESULT_STATUS_COMPLETE_KHR")]
    Complete = 1,

    [NativeName("VK_QUERY_RESULT_STATUS_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_KHR")]
    InsufficientBitstreamBufferRange = -1000299000,
}
