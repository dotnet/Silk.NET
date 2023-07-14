// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT")]
    public enum ShaderMinPrecisionSupport : int
    {
        [Obsolete("Deprecated in favour of \"SupportNone\"")]
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_NONE")]
        ShaderMinPrecisionSupportNone = 0x0,
        [Obsolete("Deprecated in favour of \"Support10Bit\"")]
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_10_BIT")]
        ShaderMinPrecisionSupport10Bit = 0x1,
        [Obsolete("Deprecated in favour of \"Support16Bit\"")]
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_16_BIT")]
        ShaderMinPrecisionSupport16Bit = 0x2,
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_NONE")]
        SupportNone = 0x0,
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_10_BIT")]
        Support10Bit = 0x1,
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_16_BIT")]
        Support16Bit = 0x2,
    }
}
