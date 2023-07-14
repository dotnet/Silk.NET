// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvDim_")]
    public enum Dim : int
    {
        [NativeName("Name", "SpvDim1D")]
        Dim1D = 0x0,
        [NativeName("Name", "SpvDim2D")]
        Dim2D = 0x1,
        [NativeName("Name", "SpvDim3D")]
        Dim3D = 0x2,
        [NativeName("Name", "SpvDimCube")]
        DimCube = 0x3,
        [NativeName("Name", "SpvDimRect")]
        DimRect = 0x4,
        [NativeName("Name", "SpvDimBuffer")]
        DimBuffer = 0x5,
        [NativeName("Name", "SpvDimSubpassData")]
        DimSubpassData = 0x6,
        [NativeName("Name", "SpvDimTileImageDataEXT")]
        DimTileImageDataExt = 0x104D,
        [NativeName("Name", "SpvDimMax")]
        DimMax = 0x7FFFFFFF,
    }
}
