// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHADER_VISIBILITY")]
    public enum ShaderVisibility : int
    {
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_ALL")]
        ShaderVisibilityAll = 0x0,
        [Obsolete("Deprecated in favour of \"Vertex\"")]
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_VERTEX")]
        ShaderVisibilityVertex = 0x1,
        [Obsolete("Deprecated in favour of \"Hull\"")]
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_HULL")]
        ShaderVisibilityHull = 0x2,
        [Obsolete("Deprecated in favour of \"Domain\"")]
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_DOMAIN")]
        ShaderVisibilityDomain = 0x3,
        [Obsolete("Deprecated in favour of \"Geometry\"")]
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_GEOMETRY")]
        ShaderVisibilityGeometry = 0x4,
        [Obsolete("Deprecated in favour of \"Pixel\"")]
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_PIXEL")]
        ShaderVisibilityPixel = 0x5,
        [Obsolete("Deprecated in favour of \"Amplification\"")]
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_AMPLIFICATION")]
        ShaderVisibilityAmplification = 0x6,
        [Obsolete("Deprecated in favour of \"Mesh\"")]
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_MESH")]
        ShaderVisibilityMesh = 0x7,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_ALL")]
        All = 0x0,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_VERTEX")]
        Vertex = 0x1,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_HULL")]
        Hull = 0x2,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_DOMAIN")]
        Domain = 0x3,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_GEOMETRY")]
        Geometry = 0x4,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_PIXEL")]
        Pixel = 0x5,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_AMPLIFICATION")]
        Amplification = 0x6,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_MESH")]
        Mesh = 0x7,
    }
}
