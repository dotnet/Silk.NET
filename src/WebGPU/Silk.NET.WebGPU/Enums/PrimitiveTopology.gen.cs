// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUPrimitiveTopology")]
    public enum PrimitiveTopology : int
    {
        [NativeName("Name", "WGPUPrimitiveTopology_PointList")]
        PointList = 0x0,
        [NativeName("Name", "WGPUPrimitiveTopology_LineList")]
        LineList = 0x1,
        [NativeName("Name", "WGPUPrimitiveTopology_LineStrip")]
        LineStrip = 0x2,
        [NativeName("Name", "WGPUPrimitiveTopology_TriangleList")]
        TriangleList = 0x3,
        [NativeName("Name", "WGPUPrimitiveTopology_TriangleStrip")]
        TriangleStrip = 0x4,
        [NativeName("Name", "WGPUPrimitiveTopology_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
