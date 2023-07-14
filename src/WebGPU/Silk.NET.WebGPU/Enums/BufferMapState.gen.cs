// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUBufferMapState")]
    public enum BufferMapState : int
    {
        [NativeName("Name", "WGPUBufferMapState_Unmapped")]
        Unmapped = 0x0,
        [NativeName("Name", "WGPUBufferMapState_Pending")]
        Pending = 0x1,
        [NativeName("Name", "WGPUBufferMapState_Mapped")]
        Mapped = 0x2,
        [NativeName("Name", "WGPUBufferMapState_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
