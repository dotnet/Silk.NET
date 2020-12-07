// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_SHADER_MIN_PRECISION_SUPPORT")]
    public enum ShaderMinPrecisionSupport
    {
        [NativeName("Name", "D3D11_SHADER_MIN_PRECISION_10_BIT")]
        ShaderMinPrecision10Bit = 0x1,
        [NativeName("Name", "D3D11_SHADER_MIN_PRECISION_16_BIT")]
        ShaderMinPrecision16Bit = 0x2,
    }
}
