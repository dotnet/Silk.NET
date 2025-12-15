// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUPopErrorScopeStatus")]
    public enum PopErrorScopeStatus : int
    {
        [NativeName("Name", "WGPUPopErrorScopeStatus_Success")]
        Success = 0x0,
        [NativeName("Name", "WGPUPopErrorScopeStatus_InstanceDropped")]
        InstanceDropped = 0x1,
        [NativeName("Name", "WGPUPopErrorScopeStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
