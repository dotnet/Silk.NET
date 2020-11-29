// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MESH_SHADER_TIER")]
    public enum MeshShaderTier
    {
        [NativeName("Name", "D3D12_MESH_SHADER_TIER_NOT_SUPPORTED")]
        MeshShaderTierNotSupported = 0x0,
        [NativeName("Name", "D3D12_MESH_SHADER_TIER_1")]
        MeshShaderTier1 = 0xA,
    }
}
