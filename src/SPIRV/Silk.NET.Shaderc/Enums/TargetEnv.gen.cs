// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Shaderc
{
    [NativeName("AnonymousName", "__AnonymousEnum_env_L24_C9")]
    [NativeName("Name", "shaderc_target_env")]
    public enum TargetEnv : int
    {
        [NativeName("Name", "shaderc_target_env_vulkan")]
        Vulkan = 0x0,
        [NativeName("Name", "shaderc_target_env_opengl")]
        Opengl = 0x1,
        [NativeName("Name", "shaderc_target_env_opengl_compat")]
        OpenglCompat = 0x2,
        [NativeName("Name", "shaderc_target_env_webgpu")]
        Webgpu = 0x3,
        [NativeName("Name", "shaderc_target_env_default")]
        Default = 0x0,
    }
}
