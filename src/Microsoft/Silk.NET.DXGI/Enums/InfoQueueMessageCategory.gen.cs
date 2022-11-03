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
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_UNKNOWN")]
        InfoQueueMessageCategoryUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Miscellaneous\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_MISCELLANEOUS")]
        InfoQueueMessageCategoryMiscellaneous = 0x1,
        [Obsolete("Deprecated in favour of \"Initialization\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_INITIALIZATION")]
        InfoQueueMessageCategoryInitialization = 0x2,
        [Obsolete("Deprecated in favour of \"Cleanup\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_CLEANUP")]
        InfoQueueMessageCategoryCleanup = 0x3,
        [Obsolete("Deprecated in favour of \"Compilation\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_COMPILATION")]
        InfoQueueMessageCategoryCompilation = 0x4,
        [Obsolete("Deprecated in favour of \"StateCreation\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_CREATION")]
        InfoQueueMessageCategoryStateCreation = 0x5,
        [Obsolete("Deprecated in favour of \"StateSetting\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_SETTING")]
        InfoQueueMessageCategoryStateSetting = 0x6,
        [Obsolete("Deprecated in favour of \"StateGetting\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_GETTING")]
        InfoQueueMessageCategoryStateGetting = 0x7,
        [Obsolete("Deprecated in favour of \"ResourceManipulation\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_RESOURCE_MANIPULATION")]
        InfoQueueMessageCategoryResourceManipulation = 0x8,
        [Obsolete("Deprecated in favour of \"Execution\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_EXECUTION")]
        InfoQueueMessageCategoryExecution = 0x9,
        [Obsolete("Deprecated in favour of \"Shader\"")]
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_SHADER")]
        InfoQueueMessageCategoryShader = 0xA,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_MISCELLANEOUS")]
        Miscellaneous = 0x1,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_INITIALIZATION")]
        Initialization = 0x2,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_CLEANUP")]
        Cleanup = 0x3,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_COMPILATION")]
        Compilation = 0x4,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_CREATION")]
        StateCreation = 0x5,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_SETTING")]
        StateSetting = 0x6,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_STATE_GETTING")]
        StateGetting = 0x7,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_RESOURCE_MANIPULATION")]
        ResourceManipulation = 0x8,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_EXECUTION")]
        Execution = 0x9,
        [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY_SHADER")]
        Shader = 0xA,
    }
}
