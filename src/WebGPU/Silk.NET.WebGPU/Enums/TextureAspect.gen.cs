// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUTextureAspect")]
    public enum TextureAspect : int
    {
        [NativeName("Name", "WGPUTextureAspect_All")]
        All = 0x0,
        [NativeName("Name", "WGPUTextureAspect_StencilOnly")]
        StencilOnly = 0x1,
        [NativeName("Name", "WGPUTextureAspect_DepthOnly")]
        DepthOnly = 0x2,
        [NativeName("Name", "WGPUTextureAspect_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
