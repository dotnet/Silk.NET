// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkQueryResultFlags")]
    public enum QueryResultFlags
    {
        [NativeName("Name", "VK_QUERY_RESULT_64_BIT")]
        QueryResult64Bit = 1,
        [NativeName("Name", "VK_QUERY_RESULT_WAIT_BIT")]
        QueryResultWaitBit = 2,
        [NativeName("Name", "VK_QUERY_RESULT_WITH_AVAILABILITY_BIT")]
        QueryResultWithAvailabilityBit = 4,
        [NativeName("Name", "VK_QUERY_RESULT_PARTIAL_BIT")]
        QueryResultPartialBit = 8,
    }
}
