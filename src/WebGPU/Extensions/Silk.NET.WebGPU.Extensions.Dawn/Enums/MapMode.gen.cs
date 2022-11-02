// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUMapMode")]
    public enum MapMode : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "WGPUMapMode_None")]
        MapModeNone = 0x0,
        [Obsolete("Deprecated in favour of \"Read\"")]
        [NativeName("Name", "WGPUMapMode_Read")]
        MapModeRead = 0x1,
        [Obsolete("Deprecated in favour of \"Write\"")]
        [NativeName("Name", "WGPUMapMode_Write")]
        MapModeWrite = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUMapMode_Force32")]
        MapModeForce32 = 0x7FFFFFFF,
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
