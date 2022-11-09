// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUTextureComponentType")]
    public enum TextureComponentType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "WGPUTextureComponentType_Float")]
        Float = 0x0,
        [NativeName("Name", "WGPUTextureComponentType_Sint")]
        Sint = 0x1,
        [NativeName("Name", "WGPUTextureComponentType_Uint")]
        Uint = 0x2,
        [NativeName("Name", "WGPUTextureComponentType_DepthComparison")]
        DepthComparison = 0x3,
        [NativeName("Name", "WGPUTextureComponentType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
