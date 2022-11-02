// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUTextureComponentType")]
    public enum TextureComponentType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Float\"")]
        [NativeName("Name", "WGPUTextureComponentType_Float")]
        TextureComponentTypeFloat = 0x0,
        [Obsolete("Deprecated in favour of \"Sint\"")]
        [NativeName("Name", "WGPUTextureComponentType_Sint")]
        TextureComponentTypeSint = 0x1,
        [Obsolete("Deprecated in favour of \"Uint\"")]
        [NativeName("Name", "WGPUTextureComponentType_Uint")]
        TextureComponentTypeUint = 0x2,
        [Obsolete("Deprecated in favour of \"DepthComparison\"")]
        [NativeName("Name", "WGPUTextureComponentType_DepthComparison")]
        TextureComponentTypeDepthComparison = 0x3,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUTextureComponentType_Force32")]
        TextureComponentTypeForce32 = 0x7FFFFFFF,
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
