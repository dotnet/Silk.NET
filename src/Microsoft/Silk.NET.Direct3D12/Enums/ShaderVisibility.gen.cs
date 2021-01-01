// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHADER_VISIBILITY")]
    public enum ShaderVisibility : int
    {
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_ALL")]
        ShaderVisibilityAll = 0x0,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_VERTEX")]
        ShaderVisibilityVertex = 0x1,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_HULL")]
        ShaderVisibilityHull = 0x2,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_DOMAIN")]
        ShaderVisibilityDomain = 0x3,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_GEOMETRY")]
        ShaderVisibilityGeometry = 0x4,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_PIXEL")]
        ShaderVisibilityPixel = 0x5,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_AMPLIFICATION")]
        ShaderVisibilityAmplification = 0x6,
        [NativeName("Name", "D3D12_SHADER_VISIBILITY_MESH")]
        ShaderVisibilityMesh = 0x7,
    }
}
