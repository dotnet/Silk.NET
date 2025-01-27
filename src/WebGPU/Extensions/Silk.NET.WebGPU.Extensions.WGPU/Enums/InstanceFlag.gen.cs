// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [Flags]
    [NativeName("Name", "WGPUInstanceFlag")]
    public enum InstanceFlag : int
    {
        [NativeName("Name", "WGPUInstanceFlag_Default")]
        Default = 0x0,
        [NativeName("Name", "WGPUInstanceFlag_Debug")]
        Debug = 0x1,
        [NativeName("Name", "WGPUInstanceFlag_Validation")]
        Validation = 0x2,
        [NativeName("Name", "WGPUInstanceFlag_DiscardHalLabels")]
        DiscardHalLabels = 0x4,
        [NativeName("Name", "WGPUInstanceFlag_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
