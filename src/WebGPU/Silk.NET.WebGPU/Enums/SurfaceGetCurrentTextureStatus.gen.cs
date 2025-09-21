// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUSurfaceGetCurrentTextureStatus")]
    public enum SurfaceGetCurrentTextureStatus : int
    {
        [NativeName("Name", "WGPUSurfaceGetCurrentTextureStatus_SuccessOptimal")]
        SuccessOptimal = 0x1,
        [NativeName("Name", "WGPUSurfaceGetCurrentTextureStatus_SuccessSuboptimal")]
        SuccessSuboptimal = 0x2,
        [NativeName("Name", "WGPUSurfaceGetCurrentTextureStatus_Timeout")]
        Timeout = 0x3,
        [NativeName("Name", "WGPUSurfaceGetCurrentTextureStatus_Outdated")]
        Outdated = 0x4,
        [NativeName("Name", "WGPUSurfaceGetCurrentTextureStatus_Lost")]
        Lost = 0x5,
        [NativeName("Name", "WGPUSurfaceGetCurrentTextureStatus_Error")]
        Error = 0x6,
        [NativeName("Name", "WGPUSurfaceGetCurrentTextureStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
