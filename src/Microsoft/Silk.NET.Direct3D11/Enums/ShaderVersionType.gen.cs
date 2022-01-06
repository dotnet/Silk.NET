// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_SHADER_VERSION_TYPE")]
    public enum ShaderVersionType : int
    {
        [NativeName("Name", "D3D11_SHVER_PIXEL_SHADER")]
        ShverPixelShader = 0x0,
        [NativeName("Name", "D3D11_SHVER_VERTEX_SHADER")]
        ShverVertexShader = 0x1,
        [NativeName("Name", "D3D11_SHVER_GEOMETRY_SHADER")]
        ShverGeometryShader = 0x2,
        [NativeName("Name", "D3D11_SHVER_HULL_SHADER")]
        ShverHullShader = 0x3,
        [NativeName("Name", "D3D11_SHVER_DOMAIN_SHADER")]
        ShverDomainShader = 0x4,
        [NativeName("Name", "D3D11_SHVER_COMPUTE_SHADER")]
        ShverComputeShader = 0x5,
        [NativeName("Name", "D3D11_SHVER_RESERVED0")]
        ShverReserved0 = 0xFFF0,
    }
}
