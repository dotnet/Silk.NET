// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_PRIMITIVE_TOPOLOGY_TYPE")]
    public enum PrimitiveTopologyType : int
    {
        [NativeName("Name", "D3D12_PRIMITIVE_TOPOLOGY_TYPE_UNDEFINED")]
        PrimitiveTopologyTypeUndefined = 0x0,
        [NativeName("Name", "D3D12_PRIMITIVE_TOPOLOGY_TYPE_POINT")]
        PrimitiveTopologyTypePoint = 0x1,
        [NativeName("Name", "D3D12_PRIMITIVE_TOPOLOGY_TYPE_LINE")]
        PrimitiveTopologyTypeLine = 0x2,
        [NativeName("Name", "D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE")]
        PrimitiveTopologyTypeTriangle = 0x3,
        [NativeName("Name", "D3D12_PRIMITIVE_TOPOLOGY_TYPE_PATCH")]
        PrimitiveTopologyTypePatch = 0x4,
    }
}
