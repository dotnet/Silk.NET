// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_platform")]
    public enum MslPlatform : int
    {
        [NativeName("Name", "SPVC_MSL_PLATFORM_IOS")]
        Ios = 0x0,
        [NativeName("Name", "SPVC_MSL_PLATFORM_MACOS")]
        Macos = 0x1,
        [NativeName("Name", "SPVC_MSL_PLATFORM_MAX_INT")]
        MaxInt = 0x7FFFFFFF,
    }
}
