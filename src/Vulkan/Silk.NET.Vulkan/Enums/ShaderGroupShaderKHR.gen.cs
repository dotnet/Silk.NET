// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
