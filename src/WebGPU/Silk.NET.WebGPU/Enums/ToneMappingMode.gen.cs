// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUToneMappingMode")]
    public enum ToneMappingMode : int
    {
        [NativeName("Name", "WGPUToneMappingMode_Standard")]
        Standard = 0x1,
        [NativeName("Name", "WGPUToneMappingMode_Extended")]
        Extended = 0x2,
        [NativeName("Name", "WGPUToneMappingMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
