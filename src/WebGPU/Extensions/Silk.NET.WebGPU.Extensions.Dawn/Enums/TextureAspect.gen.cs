// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUTextureAspect")]
    public enum TextureAspect : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "WGPUTextureAspect_All")]
        TextureAspectAll = 0x0,
        [Obsolete("Deprecated in favour of \"StencilOnly\"")]
        [NativeName("Name", "WGPUTextureAspect_StencilOnly")]
        TextureAspectStencilOnly = 0x1,
        [Obsolete("Deprecated in favour of \"DepthOnly\"")]
        [NativeName("Name", "WGPUTextureAspect_DepthOnly")]
        TextureAspectDepthOnly = 0x2,
        [Obsolete("Deprecated in favour of \"Plane0Only\"")]
        [NativeName("Name", "WGPUTextureAspect_Plane0Only")]
        TextureAspectPlane0Only = 0x3,
        [Obsolete("Deprecated in favour of \"Plane1Only\"")]
        [NativeName("Name", "WGPUTextureAspect_Plane1Only")]
        TextureAspectPlane1Only = 0x4,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUTextureAspect_Force32")]
        TextureAspectForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUTextureAspect_All")]
        All = 0x0,
        [NativeName("Name", "WGPUTextureAspect_StencilOnly")]
        StencilOnly = 0x1,
        [NativeName("Name", "WGPUTextureAspect_DepthOnly")]
        DepthOnly = 0x2,
        [NativeName("Name", "WGPUTextureAspect_Plane0Only")]
        Plane0Only = 0x3,
        [NativeName("Name", "WGPUTextureAspect_Plane1Only")]
        Plane1Only = 0x4,
        [NativeName("Name", "WGPUTextureAspect_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
