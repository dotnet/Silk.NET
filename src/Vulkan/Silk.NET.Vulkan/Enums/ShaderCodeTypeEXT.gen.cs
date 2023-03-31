// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkShaderCodeTypeEXT")]
    public enum ShaderCodeTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"BinaryExt\"")]
        [NativeName("Name", "VK_SHADER_CODE_TYPE_BINARY_EXT")]
        ShaderCodeTypeBinaryExt = 0,
        [Obsolete("Deprecated in favour of \"SpirvExt\"")]
        [NativeName("Name", "VK_SHADER_CODE_TYPE_SPIRV_EXT")]
        ShaderCodeTypeSpirvExt = 1,
        [NativeName("Name", "VK_SHADER_CODE_TYPE_BINARY_EXT")]
        BinaryExt = 0,
        [NativeName("Name", "VK_SHADER_CODE_TYPE_SPIRV_EXT")]
        SpirvExt = 1,
    }
}
