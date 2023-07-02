// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Shaderc
{
    [NativeName("AnonymousName", "__AnonymousEnum_env_L53_C9")]
    [NativeName("Name", "shaderc_spirv_version")]
    public enum SpirvVersion : int
    {
        [NativeName("Name", "shaderc_spirv_version_1_0")]
        Shaderc10 = 0x10000,
        [NativeName("Name", "shaderc_spirv_version_1_1")]
        Shaderc11 = 0x10100,
        [NativeName("Name", "shaderc_spirv_version_1_2")]
        Shaderc12 = 0x10200,
        [NativeName("Name", "shaderc_spirv_version_1_3")]
        Shaderc13 = 0x10300,
        [NativeName("Name", "shaderc_spirv_version_1_4")]
        Shaderc14 = 0x10400,
        [NativeName("Name", "shaderc_spirv_version_1_5")]
        Shaderc15 = 0x10500,
        [NativeName("Name", "shaderc_spirv_version_1_6")]
        Shaderc16 = 0x10600,
    }
}
