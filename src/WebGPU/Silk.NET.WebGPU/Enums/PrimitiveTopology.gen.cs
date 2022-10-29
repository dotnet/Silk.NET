// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUPrimitiveTopology")]
    public enum PrimitiveTopology : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PointList\"")]
        [NativeName("Name", "WGPUPrimitiveTopology_PointList")]
        PrimitiveTopologyPointList = 0x0,
        [Obsolete("Deprecated in favour of \"LineList\"")]
        [NativeName("Name", "WGPUPrimitiveTopology_LineList")]
        PrimitiveTopologyLineList = 0x1,
        [Obsolete("Deprecated in favour of \"LineStrip\"")]
        [NativeName("Name", "WGPUPrimitiveTopology_LineStrip")]
        PrimitiveTopologyLineStrip = 0x2,
        [Obsolete("Deprecated in favour of \"TriangleList\"")]
        [NativeName("Name", "WGPUPrimitiveTopology_TriangleList")]
        PrimitiveTopologyTriangleList = 0x3,
        [Obsolete("Deprecated in favour of \"TriangleStrip\"")]
        [NativeName("Name", "WGPUPrimitiveTopology_TriangleStrip")]
        PrimitiveTopologyTriangleStrip = 0x4,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUPrimitiveTopology_Force32")]
        PrimitiveTopologyForce32 = 0x7FFFFFFF,
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
