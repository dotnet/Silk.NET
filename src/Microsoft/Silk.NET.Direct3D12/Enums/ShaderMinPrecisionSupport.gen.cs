// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT")]
    public enum ShaderMinPrecisionSupport : int
    {
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_NONE")]
        ShaderMinPrecisionSupportNone = 0x0,
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_10_BIT")]
        ShaderMinPrecisionSupport10Bit = 0x1,
        [NativeName("Name", "D3D12_SHADER_MIN_PRECISION_SUPPORT_16_BIT")]
        ShaderMinPrecisionSupport16Bit = 0x2,
    }
}
