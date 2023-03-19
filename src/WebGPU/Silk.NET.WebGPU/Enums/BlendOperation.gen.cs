// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUBlendOperation")]
    public enum BlendOperation : int
    {
        [NativeName("Name", "WGPUBlendOperation_Add")]
        Add = 0x0,
        [NativeName("Name", "WGPUBlendOperation_Subtract")]
        Subtract = 0x1,
        [NativeName("Name", "WGPUBlendOperation_ReverseSubtract")]
        ReverseSubtract = 0x2,
        [NativeName("Name", "WGPUBlendOperation_Min")]
        Min = 0x3,
        [NativeName("Name", "WGPUBlendOperation_Max")]
        Max = 0x4,
        [NativeName("Name", "WGPUBlendOperation_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
