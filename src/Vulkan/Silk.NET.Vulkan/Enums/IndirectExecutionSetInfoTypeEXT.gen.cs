// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkIndirectExecutionSetInfoTypeEXT")]
    public enum IndirectExecutionSetInfoTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"PipelinesExt\"")]
        [NativeName("Name", "VK_INDIRECT_EXECUTION_SET_INFO_TYPE_PIPELINES_EXT")]
        IndirectExecutionSetInfoTypePipelinesExt = 0,
        [Obsolete("Deprecated in favour of \"ShaderObjectsExt\"")]
        [NativeName("Name", "VK_INDIRECT_EXECUTION_SET_INFO_TYPE_SHADER_OBJECTS_EXT")]
        IndirectExecutionSetInfoTypeShaderObjectsExt = 1,
        [NativeName("Name", "VK_INDIRECT_EXECUTION_SET_INFO_TYPE_PIPELINES_EXT")]
        PipelinesExt = 0,
        [NativeName("Name", "VK_INDIRECT_EXECUTION_SET_INFO_TYPE_SHADER_OBJECTS_EXT")]
        ShaderObjectsExt = 1,
    }
}
