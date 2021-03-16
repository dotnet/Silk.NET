// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_SHADER_TYPE")]
    public enum ShaderType : int
    {
        [NativeName("Name", "D3D11_VERTEX_SHADER")]
        VertexShader = 0x1,
        [NativeName("Name", "D3D11_HULL_SHADER")]
        HullShader = 0x2,
        [NativeName("Name", "D3D11_DOMAIN_SHADER")]
        DomainShader = 0x3,
        [NativeName("Name", "D3D11_GEOMETRY_SHADER")]
        GeometryShader = 0x4,
        [NativeName("Name", "D3D11_PIXEL_SHADER")]
        PixelShader = 0x5,
        [NativeName("Name", "D3D11_COMPUTE_SHADER")]
        ComputeShader = 0x6,
    }
}
