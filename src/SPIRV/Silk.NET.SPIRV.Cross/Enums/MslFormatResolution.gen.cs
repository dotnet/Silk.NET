// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_format_resolution")]
    public enum MslFormatResolution : int
    {
        [NativeName("Name", "SPVC_MSL_FORMAT_RESOLUTION_444")]
        Resolution444 = 0x0,
        [NativeName("Name", "SPVC_MSL_FORMAT_RESOLUTION_422")]
        Resolution422 = 0x1,
        [NativeName("Name", "SPVC_MSL_FORMAT_RESOLUTION_420")]
        Resolution420 = 0x2,
        [NativeName("Name", "SPVC_MSL_FORMAT_RESOLUTION_INT_MAX")]
        ResolutionIntMax = 0x7FFFFFFF,
    }
}
