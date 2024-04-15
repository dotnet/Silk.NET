// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUAlphaMode")]
    public enum AlphaMode : int
    {
        [NativeName("Name", "WGPUAlphaMode_Opaque")]
        Opaque = 0x1,
        [NativeName("Name", "WGPUAlphaMode_Premultiplied")]
        Premultiplied = 0x2,
        [NativeName("Name", "WGPUAlphaMode_Unpremultiplied")]
        Unpremultiplied = 0x3,
        [NativeName("Name", "WGPUAlphaMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
