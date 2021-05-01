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
        [NativeName("Name", "VK_QUERY_RESULT_STATUS_ERROR_KHR")]
        QueryResultStatusErrorKhr = -1,
        [NativeName("Name", "VK_QUERY_RESULT_STATUS_NOT_READY_KHR")]
        QueryResultStatusNotReadyKhr = 0,
        [NativeName("Name", "VK_QUERY_RESULT_STATUS_COMPLETE_KHR")]
        QueryResultStatusCompleteKhr = 1,
    }
}
