// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_SHADER_MIN_PRECISION_SUPPORT")]
    public enum ShaderMinPrecisionSupport : int
    {
        [NativeName("Name", "D3D11_SHADER_MIN_PRECISION_10_BIT")]
        ShaderMinPrecision10Bit = 0x1,
        [NativeName("Name", "D3D11_SHADER_MIN_PRECISION_16_BIT")]
        ShaderMinPrecision16Bit = 0x2,
    }
}
