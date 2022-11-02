// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUAddressMode")]
    public enum AddressMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Repeat\"")]
        [NativeName("Name", "WGPUAddressMode_Repeat")]
        AddressModeRepeat = 0x0,
        [Obsolete("Deprecated in favour of \"MirrorRepeat\"")]
        [NativeName("Name", "WGPUAddressMode_MirrorRepeat")]
        AddressModeMirrorRepeat = 0x1,
        [Obsolete("Deprecated in favour of \"ClampToEdge\"")]
        [NativeName("Name", "WGPUAddressMode_ClampToEdge")]
        AddressModeClampToEdge = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUAddressMode_Force32")]
        AddressModeForce32 = 0x7FFFFFFF,
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
