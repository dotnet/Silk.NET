// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUFilterMode")]
    public enum FilterMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Nearest\"")]
        [NativeName("Name", "WGPUFilterMode_Nearest")]
        FilterModeNearest = 0x0,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "WGPUFilterMode_Linear")]
        FilterModeLinear = 0x1,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUFilterMode_Force32")]
        FilterModeForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUFilterMode_Nearest")]
        Nearest = 0x0,
        [NativeName("Name", "WGPUFilterMode_Linear")]
        Linear = 0x1,
        [NativeName("Name", "WGPUFilterMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
