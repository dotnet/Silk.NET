// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY")]
    public enum InfoQueueMessageCategory : int
    {
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_UNKNOWN")]
        InfoQueueMessageCategoryUnknown = 0x0,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_MISCELLANEOUS")]
        InfoQueueMessageCategoryMiscellaneous = 0x1,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_INITIALIZATION")]
        InfoQueueMessageCategoryInitialization = 0x2,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_CLEANUP")]
        InfoQueueMessageCategoryCleanup = 0x3,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_COMPILATION")]
        InfoQueueMessageCategoryCompilation = 0x4,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_CREATION")]
        InfoQueueMessageCategoryStateCreation = 0x5,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_SETTING")]
        InfoQueueMessageCategoryStateSetting = 0x6,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_GETTING")]
        InfoQueueMessageCategoryStateGetting = 0x7,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_RESOURCE_MANIPULATION")]
        InfoQueueMessageCategoryResourceManipulation = 0x8,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_EXECUTION")]
        InfoQueueMessageCategoryExecution = 0x9,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_SHADER")]
        InfoQueueMessageCategoryShader = 0xA,
    }
}
