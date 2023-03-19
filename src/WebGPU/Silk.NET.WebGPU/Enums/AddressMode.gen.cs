// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUAddressMode")]
    public enum AddressMode : int
    {
        [NativeName("Name", "WGPUAddressMode_Repeat")]
        Repeat = 0x0,
        [NativeName("Name", "WGPUAddressMode_MirrorRepeat")]
        MirrorRepeat = 0x1,
        [NativeName("Name", "WGPUAddressMode_ClampToEdge")]
        ClampToEdge = 0x2,
        [NativeName("Name", "WGPUAddressMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
