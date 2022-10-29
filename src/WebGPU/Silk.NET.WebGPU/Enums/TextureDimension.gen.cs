// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUTextureDimension")]
    public enum TextureDimension : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "WGPUTextureDimension_1D")]
        TextureDimension1D = 0x0,
        [NativeName("Name", "WGPUTextureDimension_2D")]
        TextureDimension2D = 0x1,
        [NativeName("Name", "WGPUTextureDimension_3D")]
        TextureDimension3D = 0x2,
        [NativeName("Name", "WGPUTextureDimension_Force32")]
        TextureDimensionForce32 = 0x7FFFFFFF,
    }
}
