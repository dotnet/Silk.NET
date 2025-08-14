// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUCallbackMode")]
    public enum CallbackMode : int
    {
        [NativeName("Name", "WGPUCallbackMode_WaitAnyOnly")]
        WaitAnyOnly = 0x1,
        [NativeName("Name", "WGPUCallbackMode_AllowProcessEvents")]
        AllowProcessEvents = 0x2,
        [NativeName("Name", "WGPUCallbackMode_AllowSpontaneous")]
        AllowSpontaneous = 0x3,
        [NativeName("Name", "WGPUCallbackMode_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
