// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkQueryResultStatusKHR")]
    public enum QueryResultStatusKHR : int
    {
        [Obsolete("Deprecated in favour of \"ErrorKhr\"")]
        [NativeName("Name", "VK_QUERY_RESULT_STATUS_ERROR_KHR")]
        QueryResultStatusErrorKhr = unchecked((int) -1),
        [Obsolete("Deprecated in favour of \"NotReadyKhr\"")]
        [NativeName("Name", "VK_QUERY_RESULT_STATUS_NOT_READY_KHR")]
        QueryResultStatusNotReadyKhr = 0,
        [Obsolete("Deprecated in favour of \"CompleteKhr\"")]
        [NativeName("Name", "VK_QUERY_RESULT_STATUS_COMPLETE_KHR")]
        QueryResultStatusCompleteKhr = 1,
        [Obsolete("Deprecated in favour of \"InsufficientBitstreamBufferRangeKhr\"")]
        [NativeName("Name", "VK_QUERY_RESULT_STATUS_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_KHR")]
        QueryResultStatusInsufficientBitstreamBufferRangeKhr = unchecked((int) -1000299000),
        [NativeName("Name", "VK_QUERY_RESULT_STATUS_ERROR_KHR")]
        ErrorKhr = unchecked((int) -1),
        [NativeName("Name", "VK_QUERY_RESULT_STATUS_NOT_READY_KHR")]
        NotReadyKhr = 0,
        [NativeName("Name", "VK_QUERY_RESULT_STATUS_COMPLETE_KHR")]
        CompleteKhr = 1,
        [NativeName("Name", "VK_QUERY_RESULT_STATUS_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_KHR")]
        InsufficientBitstreamBufferRangeKhr = unchecked((int) -1000299000),
    }
}
