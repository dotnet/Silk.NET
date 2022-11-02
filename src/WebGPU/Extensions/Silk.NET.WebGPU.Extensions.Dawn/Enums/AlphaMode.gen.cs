// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUAlphaMode")]
    public enum AlphaMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Premultiplied\"")]
        [NativeName("Name", "WGPUAlphaMode_Premultiplied")]
        AlphaModePremultiplied = 0x0,
        [Obsolete("Deprecated in favour of \"Unpremultiplied\"")]
        [NativeName("Name", "WGPUAlphaMode_Unpremultiplied")]
        AlphaModeUnpremultiplied = 0x1,
        [Obsolete("Deprecated in favour of \"Opaque\"")]
        [NativeName("Name", "WGPUAlphaMode_Opaque")]
        AlphaModeOpaque = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUAlphaMode_Force32")]
        AlphaModeForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUAlphaMode_Premultiplied")]
        Premultiplied = 0x0,
        [NativeName("Name", "WGPUAlphaMode_Unpremultiplied")]
        Unpremultiplied = 0x1,
        [NativeName("Name", "WGPUAlphaMode_Opaque")]
        Opaque = 0x2,
        [NativeName("Name", "WGPUAlphaMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
