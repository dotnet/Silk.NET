// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkQueryResultFlags")]
    public enum QueryResultFlags : int
    {
        [NativeName("Name", "VK_QUERY_RESULT_64_BIT")]
        QueryResult64Bit = 1,
        [NativeName("Name", "VK_QUERY_RESULT_WAIT_BIT")]
        QueryResultWaitBit = 2,
        [NativeName("Name", "VK_QUERY_RESULT_WITH_AVAILABILITY_BIT")]
        QueryResultWithAvailabilityBit = 4,
        [NativeName("Name", "VK_QUERY_RESULT_PARTIAL_BIT")]
        QueryResultPartialBit = 8,
        [NativeName("Name", "VK_QUERY_RESULT_WITH_STATUS_BIT_KHR")]
        QueryResultWithStatusBitKhr = 16,
    }
}
