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
    [NativeName("Name", "VkShaderModuleCreateFlags")]
    public enum ShaderModuleCreateFlags : int
    {
        [NativeName("Name", "VK_SHADER_MODULE_CREATE_RESERVED_0_BIT_NV")]
        ShaderModuleCreateReserved0BitNV = 1,
    }
}
