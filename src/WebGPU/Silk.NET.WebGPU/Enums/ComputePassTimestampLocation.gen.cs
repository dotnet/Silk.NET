// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUComputePassTimestampLocation")]
    public enum ComputePassTimestampLocation : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Beginning\"")]
        [NativeName("Name", "WGPUComputePassTimestampLocation_Beginning")]
        ComputePassTimestampLocationBeginning = 0x0,
        [Obsolete("Deprecated in favour of \"End\"")]
        [NativeName("Name", "WGPUComputePassTimestampLocation_End")]
        ComputePassTimestampLocationEnd = 0x1,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUComputePassTimestampLocation_Force32")]
        ComputePassTimestampLocationForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUComputePassTimestampLocation_Beginning")]
        Beginning = 0x0,
        [NativeName("Name", "WGPUComputePassTimestampLocation_End")]
        End = 0x1,
        [NativeName("Name", "WGPUComputePassTimestampLocation_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
