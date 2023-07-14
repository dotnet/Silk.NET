// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Shaderc
{
    [NativeName("AnonymousName", "__AnonymousEnum_env_L37_C9")]
    [NativeName("Name", "shaderc_env_version")]
    public enum EnvVersion : int
    {
        [NativeName("Name", "shaderc_env_version_vulkan_1_0")]
        Vulkan10 = 0x400000,
        [NativeName("Name", "shaderc_env_version_vulkan_1_1")]
        Vulkan11 = 0x401000,
        [NativeName("Name", "shaderc_env_version_vulkan_1_2")]
        Vulkan12 = 0x402000,
        [NativeName("Name", "shaderc_env_version_vulkan_1_3")]
        Vulkan13 = 0x403000,
        [NativeName("Name", "shaderc_env_version_opengl_4_5")]
        Opengl45 = 0x1C2,
        [NativeName("Name", "shaderc_env_version_webgpu")]
        Webgpu = 0x1C3,
    }
}
