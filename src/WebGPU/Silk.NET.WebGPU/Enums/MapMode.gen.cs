// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUMapMode")]
    public enum MapMode : int
    {
        [NativeName("Name", "WGPUMapMode_None")]
        None = 0x0,
        [NativeName("Name", "WGPUMapMode_Read")]
        Read = 0x1,
        [NativeName("Name", "WGPUMapMode_Write")]
        Write = 0x2,
        [NativeName("Name", "WGPUMapMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
