// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DirectXPrimitiveTopology")]
    public enum DirectXPrimitiveTopology : int
    {
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "DirectXPrimitiveTopology_Undefined")]
        DirectXPrimitiveTopologyUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"PointList\"")]
        [NativeName("Name", "DirectXPrimitiveTopology_PointList")]
        DirectXPrimitiveTopologyPointList = 0x1,
        [Obsolete("Deprecated in favour of \"LineList\"")]
        [NativeName("Name", "DirectXPrimitiveTopology_LineList")]
        DirectXPrimitiveTopologyLineList = 0x2,
        [Obsolete("Deprecated in favour of \"LineStrip\"")]
        [NativeName("Name", "DirectXPrimitiveTopology_LineStrip")]
        DirectXPrimitiveTopologyLineStrip = 0x3,
        [Obsolete("Deprecated in favour of \"TriangleList\"")]
        [NativeName("Name", "DirectXPrimitiveTopology_TriangleList")]
        DirectXPrimitiveTopologyTriangleList = 0x4,
        [Obsolete("Deprecated in favour of \"TriangleStrip\"")]
        [NativeName("Name", "DirectXPrimitiveTopology_TriangleStrip")]
        DirectXPrimitiveTopologyTriangleStrip = 0x5,
        [NativeName("Name", "DirectXPrimitiveTopology_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "DirectXPrimitiveTopology_PointList")]
        PointList = 0x1,
        [NativeName("Name", "DirectXPrimitiveTopology_LineList")]
        LineList = 0x2,
        [NativeName("Name", "DirectXPrimitiveTopology_LineStrip")]
        LineStrip = 0x3,
        [NativeName("Name", "DirectXPrimitiveTopology_TriangleList")]
        TriangleList = 0x4,
        [NativeName("Name", "DirectXPrimitiveTopology_TriangleStrip")]
        TriangleStrip = 0x5,
    }
}
