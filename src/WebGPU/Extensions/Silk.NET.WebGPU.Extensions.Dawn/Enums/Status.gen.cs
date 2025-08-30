// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUStatus")]
    public enum Status : int
    {
        [NativeName("Name", "WGPUStatus_Success")]
        Success = 0x0,
        [NativeName("Name", "WGPUStatus_Error")]
        Error = 0x1,
        [NativeName("Name", "WGPUStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
