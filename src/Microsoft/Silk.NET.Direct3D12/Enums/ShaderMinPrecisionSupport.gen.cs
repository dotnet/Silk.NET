// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT")]
    public enum ShaderMinPrecisionSupport
    {
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_NONE")]
        ShaderMinPrecisionSupportNone = 0x0,
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_10_BIT")]
        ShaderMinPrecisionSupport10Bit = 0x1,
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_16_BIT")]
        ShaderMinPrecisionSupport16Bit = 0x2,
    }
}
