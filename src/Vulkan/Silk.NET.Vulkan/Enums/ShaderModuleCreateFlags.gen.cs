// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkShaderModuleCreateFlags")]
    public enum ShaderModuleCreateFlags : int
    {
        [NativeName("Name", "VK_SHADER_MODULE_CREATE_RESERVED_0_BIT_NV")]
        ShaderModuleCreateReserved0BitNV = 1,
    }
}
