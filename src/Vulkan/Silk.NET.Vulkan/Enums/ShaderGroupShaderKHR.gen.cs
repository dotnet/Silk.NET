// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkShaderGroupShaderKHR")]
    public enum ShaderGroupShaderKHR : int
    {
        [NativeName("Name", "VK_SHADER_GROUP_SHADER_GENERAL_KHR")]
        ShaderGroupShaderGeneralKhr = 0,
        [NativeName("Name", "VK_SHADER_GROUP_SHADER_CLOSEST_HIT_KHR")]
        ShaderGroupShaderClosestHitKhr = 1,
        [NativeName("Name", "VK_SHADER_GROUP_SHADER_ANY_HIT_KHR")]
        ShaderGroupShaderAnyHitKhr = 2,
        [NativeName("Name", "VK_SHADER_GROUP_SHADER_INTERSECTION_KHR")]
        ShaderGroupShaderIntersectionKhr = 3,
    }
}
