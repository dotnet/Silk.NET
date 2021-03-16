// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkShaderInfoTypeAMD")]
    public enum ShaderInfoTypeAMD : int
    {
        [NativeName("Name", "VK_SHADER_INFO_TYPE_STATISTICS_AMD")]
        ShaderInfoTypeStatisticsAmd = 0,
        [NativeName("Name", "VK_SHADER_INFO_TYPE_BINARY_AMD")]
        ShaderInfoTypeBinaryAmd = 1,
        [NativeName("Name", "VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD")]
        ShaderInfoTypeDisassemblyAmd = 2,
    }
}
