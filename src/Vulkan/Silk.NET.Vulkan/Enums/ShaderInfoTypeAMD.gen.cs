// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkShaderInfoTypeAMD")]
    public enum ShaderInfoTypeAMD : int
    {
        [Obsolete("Deprecated in favour of \"StatisticsAmd\"")]
        [NativeName("Name", "VK_SHADER_INFO_TYPE_STATISTICS_AMD")]
        ShaderInfoTypeStatisticsAmd = 0,
        [Obsolete("Deprecated in favour of \"BinaryAmd\"")]
        [NativeName("Name", "VK_SHADER_INFO_TYPE_BINARY_AMD")]
        ShaderInfoTypeBinaryAmd = 1,
        [Obsolete("Deprecated in favour of \"DisassemblyAmd\"")]
        [NativeName("Name", "VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD")]
        ShaderInfoTypeDisassemblyAmd = 2,
        [NativeName("Name", "VK_SHADER_INFO_TYPE_STATISTICS_AMD")]
        StatisticsAmd = 0,
        [NativeName("Name", "VK_SHADER_INFO_TYPE_BINARY_AMD")]
        BinaryAmd = 1,
        [NativeName("Name", "VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD")]
        DisassemblyAmd = 2,
    }
}
