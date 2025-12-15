// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MESSAGE_CATEGORY")]
    public enum MessageCategory : int
    {
        [Obsolete("Deprecated in favour of \"ApplicationDefined\"")]
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_APPLICATION_DEFINED")]
        MessageCategoryApplicationDefined = 0x0,
        [Obsolete("Deprecated in favour of \"Miscellaneous\"")]
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_MISCELLANEOUS")]
        MessageCategoryMiscellaneous = 0x1,
        [Obsolete("Deprecated in favour of \"Initialization\"")]
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_INITIALIZATION")]
        MessageCategoryInitialization = 0x2,
        [Obsolete("Deprecated in favour of \"Cleanup\"")]
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_CLEANUP")]
        MessageCategoryCleanup = 0x3,
        [Obsolete("Deprecated in favour of \"Compilation\"")]
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_COMPILATION")]
        MessageCategoryCompilation = 0x4,
        [Obsolete("Deprecated in favour of \"StateCreation\"")]
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_STATE_CREATION")]
        MessageCategoryStateCreation = 0x5,
        [Obsolete("Deprecated in favour of \"StateSetting\"")]
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_STATE_SETTING")]
        MessageCategoryStateSetting = 0x6,
        [Obsolete("Deprecated in favour of \"StateGetting\"")]
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_STATE_GETTING")]
        MessageCategoryStateGetting = 0x7,
        [Obsolete("Deprecated in favour of \"ResourceManipulation\"")]
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_RESOURCE_MANIPULATION")]
        MessageCategoryResourceManipulation = 0x8,
        [Obsolete("Deprecated in favour of \"Execution\"")]
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_EXECUTION")]
        MessageCategoryExecution = 0x9,
        [Obsolete("Deprecated in favour of \"Shader\"")]
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_SHADER")]
        MessageCategoryShader = 0xA,
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_APPLICATION_DEFINED")]
        ApplicationDefined = 0x0,
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_MISCELLANEOUS")]
        Miscellaneous = 0x1,
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_INITIALIZATION")]
        Initialization = 0x2,
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_CLEANUP")]
        Cleanup = 0x3,
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_COMPILATION")]
        Compilation = 0x4,
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_STATE_CREATION")]
        StateCreation = 0x5,
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_STATE_SETTING")]
        StateSetting = 0x6,
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_STATE_GETTING")]
        StateGetting = 0x7,
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_RESOURCE_MANIPULATION")]
        ResourceManipulation = 0x8,
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_EXECUTION")]
        Execution = 0x9,
        [NativeName("Name", "D3D12_MESSAGE_CATEGORY_SHADER")]
        Shader = 0xA,
    }
}
