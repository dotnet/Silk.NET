// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUBlendOperation")]
    public enum BlendOperation : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Add\"")]
        [NativeName("Name", "WGPUBlendOperation_Add")]
        BlendOperationAdd = 0x0,
        [Obsolete("Deprecated in favour of \"Subtract\"")]
        [NativeName("Name", "WGPUBlendOperation_Subtract")]
        BlendOperationSubtract = 0x1,
        [Obsolete("Deprecated in favour of \"ReverseSubtract\"")]
        [NativeName("Name", "WGPUBlendOperation_ReverseSubtract")]
        BlendOperationReverseSubtract = 0x2,
        [Obsolete("Deprecated in favour of \"Min\"")]
        [NativeName("Name", "WGPUBlendOperation_Min")]
        BlendOperationMin = 0x3,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "WGPUBlendOperation_Max")]
        BlendOperationMax = 0x4,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUBlendOperation_Force32")]
        BlendOperationForce32 = 0x7FFFFFFF,
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
