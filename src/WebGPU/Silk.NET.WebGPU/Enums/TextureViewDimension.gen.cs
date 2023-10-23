// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUTextureViewDimension")]
    public enum TextureViewDimension : int
    {
        [Obsolete("Deprecated in favour of \"DimensionUndefined\"")]
        [NativeName("Name", "WGPUTextureViewDimension_Undefined")]
        TextureViewDimensionUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Dimension1D\"")]
        [NativeName("Name", "WGPUTextureViewDimension_1D")]
        TextureViewDimension1D = 0x1,
        [Obsolete("Deprecated in favour of \"Dimension2D\"")]
        [NativeName("Name", "WGPUTextureViewDimension_2D")]
        TextureViewDimension2D = 0x2,
        [Obsolete("Deprecated in favour of \"Dimension2DArray\"")]
        [NativeName("Name", "WGPUTextureViewDimension_2DArray")]
        TextureViewDimension2DArray = 0x3,
        [Obsolete("Deprecated in favour of \"DimensionCube\"")]
        [NativeName("Name", "WGPUTextureViewDimension_Cube")]
        TextureViewDimensionCube = 0x4,
        [Obsolete("Deprecated in favour of \"DimensionCubeArray\"")]
        [NativeName("Name", "WGPUTextureViewDimension_CubeArray")]
        TextureViewDimensionCubeArray = 0x5,
        [Obsolete("Deprecated in favour of \"Dimension3D\"")]
        [NativeName("Name", "WGPUTextureViewDimension_3D")]
        TextureViewDimension3D = 0x6,
        [Obsolete("Deprecated in favour of \"DimensionForce32\"")]
        [NativeName("Name", "WGPUTextureViewDimension_Force32")]
        TextureViewDimensionForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUTextureViewDimension_Undefined")]
        DimensionUndefined = 0x0,
        [NativeName("Name", "WGPUTextureViewDimension_1D")]
        Dimension1D = 0x1,
        [NativeName("Name", "WGPUTextureViewDimension_2D")]
        Dimension2D = 0x2,
        [NativeName("Name", "WGPUTextureViewDimension_2DArray")]
        Dimension2DArray = 0x3,
        [NativeName("Name", "WGPUTextureViewDimension_Cube")]
        DimensionCube = 0x4,
        [NativeName("Name", "WGPUTextureViewDimension_CubeArray")]
        DimensionCubeArray = 0x5,
        [NativeName("Name", "WGPUTextureViewDimension_3D")]
        Dimension3D = 0x6,
        [NativeName("Name", "WGPUTextureViewDimension_Force32")]
        DimensionForce32 = 0x7FFFFFFF,
    }
}
