// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkShaderInfoTypeAMD")]
    public enum ShaderInfoTypeAMD
    {
        [NativeName("Name", "VK_SHADER_INFO_TYPE_STATISTICS_AMD")]
        ShaderInfoTypeStatisticsAmd = 0,
        [NativeName("Name", "VK_SHADER_INFO_TYPE_BINARY_AMD")]
        ShaderInfoTypeBinaryAmd = 1,
        [NativeName("Name", "VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD")]
        ShaderInfoTypeDisassemblyAmd = 2,
    }
}
