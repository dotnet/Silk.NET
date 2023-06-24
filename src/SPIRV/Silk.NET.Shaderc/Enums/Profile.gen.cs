// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Shaderc
{
    [NativeName("AnonymousName", "__AnonymousEnum_shaderc_L92_C9")]
    [NativeName("Name", "shaderc_profile")]
    public enum Profile : int
    {
        [NativeName("Name", "shaderc_profile_none")]
        None = 0x0,
        [NativeName("Name", "shaderc_profile_core")]
        Core = 0x1,
        [NativeName("Name", "shaderc_profile_compatibility")]
        Compatibility = 0x2,
        [NativeName("Name", "shaderc_profile_es")]
        Es = 0x3,
    }
}
