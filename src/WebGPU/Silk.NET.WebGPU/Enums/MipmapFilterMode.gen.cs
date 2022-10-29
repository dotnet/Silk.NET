// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUMipmapFilterMode")]
    public enum MipmapFilterMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Nearest\"")]
        [NativeName("Name", "WGPUMipmapFilterMode_Nearest")]
        MipmapFilterModeNearest = 0x0,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "WGPUMipmapFilterMode_Linear")]
        MipmapFilterModeLinear = 0x1,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUMipmapFilterMode_Force32")]
        MipmapFilterModeForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUMipmapFilterMode_Nearest")]
        Nearest = 0x0,
        [NativeName("Name", "WGPUMipmapFilterMode_Linear")]
        Linear = 0x1,
        [NativeName("Name", "WGPUMipmapFilterMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
