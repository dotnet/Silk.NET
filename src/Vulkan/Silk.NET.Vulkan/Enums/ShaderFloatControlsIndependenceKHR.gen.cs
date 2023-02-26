// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkShaderFloatControlsIndependenceKHR")]
    public enum ShaderFloatControlsIndependenceKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Independence32BitOnly\"")]
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY")]
        ShaderFloatControlsIndependence32BitOnly = 0,
        [Obsolete("Deprecated in favour of \"IndependenceAll\"")]
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL")]
        ShaderFloatControlsIndependenceAll = 1,
        [Obsolete("Deprecated in favour of \"IndependenceNone\"")]
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE")]
        ShaderFloatControlsIndependenceNone = 2,
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY")]
        Independence32BitOnly = 0,
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL")]
        IndependenceAll = 1,
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE")]
        IndependenceNone = 2,
    }
}
