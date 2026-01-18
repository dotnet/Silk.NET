// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUDxcMaxShaderModel")]
    public enum DxcMaxShaderModel : int
    {
        [NativeName("Name", "WGPUDxcMaxShaderModel_V6_0")]
        V60 = 0x0,
        [NativeName("Name", "WGPUDxcMaxShaderModel_V6_1")]
        V61 = 0x1,
        [NativeName("Name", "WGPUDxcMaxShaderModel_V6_2")]
        V62 = 0x2,
        [NativeName("Name", "WGPUDxcMaxShaderModel_V6_3")]
        V63 = 0x3,
        [NativeName("Name", "WGPUDxcMaxShaderModel_V6_4")]
        V64 = 0x4,
        [NativeName("Name", "WGPUDxcMaxShaderModel_V6_5")]
        V65 = 0x5,
        [NativeName("Name", "WGPUDxcMaxShaderModel_V6_6")]
        V66 = 0x6,
        [NativeName("Name", "WGPUDxcMaxShaderModel_V6_7")]
        V67 = 0x7,
        [NativeName("Name", "WGPUDxcMaxShaderModel_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
