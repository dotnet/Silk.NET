// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkShaderFloatControlsIndependenceKHR")]
    public enum ShaderFloatControlsIndependenceKHR : int
    {
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY")]
        ShaderFloatControlsIndependence32BitOnly = 0,
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL")]
        ShaderFloatControlsIndependenceAll = 1,
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE")]
        ShaderFloatControlsIndependenceNone = 2,
    }
}
