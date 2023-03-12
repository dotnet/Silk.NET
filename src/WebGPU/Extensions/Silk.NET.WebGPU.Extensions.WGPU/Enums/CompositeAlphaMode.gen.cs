// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [Flags]
    [NativeName("Name", "WGPUCompositeAlphaMode")]
    public enum CompositeAlphaMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "WGPUCompositeAlphaMode_Auto")]
        Auto = 0x0,
        [NativeName("Name", "WGPUCompositeAlphaMode_Opaque")]
        Opaque = 0x1,
        [NativeName("Name", "WGPUCompositeAlphaMode_PreMultiplied")]
        PreMultiplied = 0x2,
        [NativeName("Name", "WGPUCompositeAlphaMode_PostMultiplied")]
        PostMultiplied = 0x3,
        [NativeName("Name", "WGPUCompositeAlphaMode_Inherit")]
        Inherit = 0x4,
        [NativeName("Name", "WGPUCompositeAlphaMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
