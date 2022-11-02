// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPURenderPassTimestampLocation")]
    public enum RenderPassTimestampLocation : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Beginning\"")]
        [NativeName("Name", "WGPURenderPassTimestampLocation_Beginning")]
        RenderPassTimestampLocationBeginning = 0x0,
        [Obsolete("Deprecated in favour of \"End\"")]
        [NativeName("Name", "WGPURenderPassTimestampLocation_End")]
        RenderPassTimestampLocationEnd = 0x1,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPURenderPassTimestampLocation_Force32")]
        RenderPassTimestampLocationForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPURenderPassTimestampLocation_Beginning")]
        Beginning = 0x0,
        [NativeName("Name", "WGPURenderPassTimestampLocation_End")]
        End = 0x1,
        [NativeName("Name", "WGPURenderPassTimestampLocation_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
